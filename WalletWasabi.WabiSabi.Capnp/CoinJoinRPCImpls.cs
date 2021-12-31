using NBitcoin;
using System.Collections.Immutable;
using WalletWasabi.Crypto;
using WalletWasabi.WabiSabi.Client;

namespace WalletWasabi.WabiSabi.Capnp
{
	// TODO factor out WabiSabi project and make it depend on Capnp project and
	// just use implement the capnp interfaces directly with no deps on on
	// wasabi codebase, only nbitcoin, and hopefully verything but NBitcoin
	// doesn't need horrendous conversions.
	//
	// Async also needs to be embraced because these blocking wrappers are not
	// a good fit, the CoinState API is really clunky and should be replaced
	// with something event oriented.
	public record SpendableCoinClient(RPC.CoinJoin.SpendableCoin Rpc) : Client.ISpendableSmartCoin, IDisposable
	{
		private static Coin ConvertCoin(RPC.Bitcoin.Coin coin)
			=> new(new OutPoint(new uint256(coin.Outpoint.Txid.Data.ToArray()), coin.Outpoint.Nout),
				   new TxOut(Money.Satoshis(coin.TxOut.Value.Satoshis), new Script(coin.TxOut.ScriptPubKey.Data)));

		public Coin Coin { get; } = ConvertCoin(Rpc.Coin);

		public int AnonymitySetSizeEstimate => Rpc.Status.AnonymitySetSizeEstimate;

		public bool IsBanned => Rpc.Status.IsBanned;
		public bool IsConfirmed => Rpc.Status.IsConfirmed;

		public async Task<OwnershipProof> GenerateOwnershipProofAsync(CoinJoinInputCommitmentData commitmentData, CancellationToken cancellationToken = default)
		{
			RPC.CoinJoin.CommitmentData rpcCommitmentData = new() { Data = commitmentData.ToBytes() };
			var ownershipProof = await Rpc.SpendCapability.ProveOwnership(rpcCommitmentData, cancellationToken);
			return OwnershipProof.FromBytes(ownershipProof.Data.ToArray());
		}

		public async Task<(uint, WitScript)> SignAsync(Transaction unsignedTransaction, CancellationToken cancellationToken = default)
		{
			RPC.CoinJoin.RawTransaction rpcUnsignedTransaction = new() { Data = unsignedTransaction.ToBytes() };
			var (i, witness) = await Rpc.SpendCapability.Sign(rpcUnsignedTransaction, cancellationToken);
			return (i, new(witness.Pushes.Select(x => x.ToArray())));
		}

		public Task CoinJoinStartedAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.Events.CoinJoinStarted(cancellationToken_);

		public Task CoinJoinNoLongerInProgressAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.Events.CoinJoinNoLongerInProgress(cancellationToken_);

		public Task ReportedSpentAccordingToBackendAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.Events.ReportedSpentAccordingToBackend(cancellationToken_);

		public Task BannedAsync(DateTimeOffset until, CancellationToken cancellationToken_ = default)
			=> Rpc.Events.Banned(new() { UnixMilliseconds = until.ToUnixTimeMilliseconds() }, cancellationToken_);

		public void Dispose()
		{
			Rpc.SpendCapability.Dispose();
		}
	}

	public record SpendableCoinService(Client.ISpendableSmartCoin SpendableSmartCoin) : RPC.CoinJoin.ISpendCapability, RPC.CoinJoin.ICoinJoinEvents
	{
		public Task Banned(RPC.CoinJoin.DateTimeOffset until, CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.BannedAsync(DateTimeOffset.FromUnixTimeMilliseconds(until.UnixMilliseconds), cancellationToken_);

		public Task CoinJoinNoLongerInProgress(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.CoinJoinNoLongerInProgressAsync(cancellationToken_);

		public Task CoinJoinStarted(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.CoinJoinStartedAsync(cancellationToken_);

		public void Dispose()
		{
		}

		public async Task<RPC.CoinJoin.OwnershipProof> ProveOwnership(RPC.CoinJoin.CommitmentData rpcCommitmentData, CancellationToken cancellationToken_ = default)
		{
			var commitmentData = CoinJoinInputCommitmentData.FromBytes(rpcCommitmentData.Data.ToArray());
			var ownershipProof = await SpendableSmartCoin.GenerateOwnershipProofAsync(commitmentData, cancellationToken_).ConfigureAwait(false);
			return new() { Data = ownershipProof.ToBytes() };
		}

		public Task ReportedSpentAccordingToBackend(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.ReportedSpentAccordingToBackendAsync(cancellationToken_);

		public async Task<(uint, RPC.Bitcoin.WitScript)> Sign(RPC.CoinJoin.RawTransaction rpcUnsignedTransaction, CancellationToken cancellationToken_ = default)
		{
			var unsignedTransaction = Transaction.Load(rpcUnsignedTransaction.Data.ToArray(), Network.Main);
			var (i, witness) = await SpendableSmartCoin.SignAsync(unsignedTransaction, cancellationToken_);
			return (i, new() { Pushes = witness.Pushes.ToImmutableArray() });
		}
	}

	public record WalletClient(RPC.CoinJoin.IWallet Wallet) : IDisposable
	{
		public void Dispose()
		{
			Wallet.Dispose();
		}

		public async Task<IEnumerable<Client.ISpendableSmartCoin>> GetAvailableCoinsAsync(CancellationToken cancellationToken = default)
			=> (await Wallet.GetAvailableCoins(cancellationToken)).Select(c => new SpendableCoinClient(c)).ToImmutableArray();

		public async Task<IEnumerable<Script>> GetSelfSpendDestinationsAsync(int count, CancellationToken cancellationToken = default)
			=> (await Wallet.GenerateSelfSpendScripts(count, cancellationToken)).Select(s => new Script(s.Data.ToArray())).ToImmutableArray();
	}

	public record WalletService(ImmutableArray<ISpendableSmartCoin> Coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> GenerateSelfSpendScripts) : RPC.CoinJoin.IWallet
	{
		public static RPC.CoinJoin.SpendableCoin CreateSpendableCoin(ISpendableSmartCoin coin)
		{
			var coinService = new SpendableCoinService(coin);
			return new RPC.CoinJoin.SpendableCoin()
			{
				Coin = new()
				{
					TxOut = new()
					{
						ScriptPubKey = new() { Data = coin.Coin.TxOut.ScriptPubKey.ToBytes() },
						Value = new() { Satoshis = coin.Coin.TxOut.Value },
					},
					Outpoint = new()
					{
						Txid = new() { Data = coin.Coin.Outpoint.Hash.ToBytes() },
						Nout = coin.Coin.Outpoint.N,
					}
				},
				Status = new()
				{
					AnonymitySetSizeEstimate = coin.AnonymitySetSizeEstimate,
					IsBanned = coin.IsBanned,
					IsConfirmed = coin.IsConfirmed,
				},
				SpendCapability = coinService,
				Events = coinService,
			};
		}

		Task<IReadOnlyList<RPC.CoinJoin.SpendableCoin>> RPC.CoinJoin.IWallet.GetAvailableCoins(CancellationToken _)
			=> Task.FromResult<IReadOnlyList<RPC.CoinJoin.SpendableCoin>>(Coins.Select(CreateSpendableCoin).ToImmutableArray());

		async Task<IReadOnlyList<RPC.Bitcoin.Script>> RPC.CoinJoin.IWallet.GenerateSelfSpendScripts(int count, CancellationToken cancellationToken)
			=> (await GenerateSelfSpendScripts(count, cancellationToken)).Select(s => new RPC.Bitcoin.Script()
			{
				Data = s.ToBytes()
			}).ToImmutableArray();

		public void Dispose()
		{
		}
	}

	public record CoinJoinerClient(RPC.CoinJoin.ICoinJoiner Rpc) : Client.ICoinJoinClient, IDisposable
	{
		public void Dispose()
		{
			Rpc.Dispose();
		}

		public Task<bool> StartCoinJoinAsync(IEnumerable<ISpendableSmartCoin> coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> getSelfSpendDestinations, CancellationToken cancellationToken)
#pragma warning disable CA2000 // Dispose objects before losing scope
			=> Rpc.StartCoinJoin(wallet: new WalletService(coins.ToImmutableArray(), getSelfSpendDestinations), cancellationToken);
#pragma warning restore CA2000 // Dispose objects before losing scope
	}

	public record CoinJoinerService(Client.ICoinJoinClient Client) : RPC.CoinJoin.ICoinJoiner
	{
		public void Dispose()
		{
		}

		public async Task<bool> StartCoinJoin(RPC.CoinJoin.IWallet rpcWallet, CancellationToken cancellationToken_ = default)
		{
			using WalletClient wallet = new(rpcWallet);
			var coins = (await wallet.GetAvailableCoinsAsync(cancellationToken_)).ToImmutableArray();
			return await Client.StartCoinJoinAsync(coins, wallet.GetSelfSpendDestinationsAsync, cancellationToken_);
		}
	}
}
