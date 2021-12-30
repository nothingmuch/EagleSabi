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
	public record SpendableSmartCoinClient(RPC.CoinJoin.ISpendableSmartCoin Rpc) : Client.ISpendableSmartCoin, IDisposable
	{
		private static Coin ConvertCoin(RPC.Bitcoin.Coin coin)
			=> new(new OutPoint(new uint256(coin.Outpoint.Txid.Data.ToArray()), coin.Outpoint.Nout),
				   new TxOut(Money.Satoshis(coin.TxOut.Value.Satoshis), new Script(coin.TxOut.ScriptPubKey.Data)));

		public async Task<Coin> GetCoinAsync(CancellationToken cancellationToken_ = default) => ConvertCoin(await Rpc.Coin(cancellationToken_));

		private RPC.CoinJoin.CoinStatus State => Task.Run(() => Rpc.GetStatus()).Result;

		public int AnonymitySetSizeEstimate => State.AnonymitySetSizeEstimate;

		public bool IsBanned => State.IsBanned;
		public bool IsConfirmed => State.IsConfirmed;

		public async Task<OwnershipProof> GenerateOwnershipProofAsync(CoinJoinInputCommitmentData commitmentData, CancellationToken cancellationToken = default)
			=> OwnershipProof.FromBytes((await Rpc.ProveOwnership(new RPC.CoinJoin.CommitmentData() { Data = commitmentData.ToBytes() }, cancellationToken)).Data.ToArray());

		public async Task<(uint, WitScript)> SignAsync(Transaction transaction, CancellationToken cancellationToken = default)
		{
			var (i, witness) = await Rpc.Sign(new RPC.CoinJoin.RawTransaction() { Data = transaction.ToBytes() }, cancellationToken);
			return (i, new WitScript(witness.Pushes.Select(x => x.ToArray())));
		}

		public Task CoinJoinStartedAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.CoinJoinStarted(cancellationToken_);

		public Task CoinJoinNoLongerInProgressAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.CoinJoinNoLongerInProgress(cancellationToken_);

		public Task ReportedSpentAccordingToBackendAsync(CancellationToken cancellationToken_ = default)
			=> Rpc.ReportedSpentAccordingToBackend(cancellationToken_);

		public Task BannedAsync(DateTimeOffset until, CancellationToken cancellationToken_ = default)
			=> Rpc.Banned(new RPC.CoinJoin.DateTimeOffset() { UnixMilliseconds = until.ToUnixTimeMilliseconds() }, cancellationToken_);

		public void Dispose()
		{
			Rpc.Dispose();
		}
	}

	public record SpendableSmartCoinService(Client.ISpendableSmartCoin SpendableSmartCoin) : RPC.CoinJoin.ISpendableSmartCoin
	{
		public Task Banned(RPC.CoinJoin.DateTimeOffset until, CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.BannedAsync(DateTimeOffset.FromUnixTimeMilliseconds(until.UnixMilliseconds), cancellationToken_);

		public async Task<RPC.Bitcoin.Coin> Coin(CancellationToken cancellationToken_ = default)
		{
			var coin = await SpendableSmartCoin.GetCoinAsync(cancellationToken_).ConfigureAwait(false);

			return new()
			{
				TxOut = new()
				{
					ScriptPubKey = new() { Data = coin.TxOut.ScriptPubKey.ToBytes() },
					Value = new() { Satoshis = coin.TxOut.Value },
				},
				Outpoint = new()
				{
					Txid = new() { Data = coin.Outpoint.Hash.ToBytes() },
					Nout = coin.Outpoint.N,
				}
			};
		}

		public Task CoinJoinNoLongerInProgress(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.CoinJoinNoLongerInProgressAsync(cancellationToken_);

		public Task CoinJoinStarted(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.CoinJoinStartedAsync(cancellationToken_);

		public void Dispose()
		{
		}

		public Task<RPC.CoinJoin.CoinStatus> GetStatus(CancellationToken cancellationToken_ = default)
			=> Task.FromResult(new RPC.CoinJoin.CoinStatus()
			{
				AnonymitySetSizeEstimate = SpendableSmartCoin.AnonymitySetSizeEstimate,
				IsBanned = SpendableSmartCoin.IsBanned,
				IsConfirmed = SpendableSmartCoin.IsConfirmed,
			});

		public async Task<RPC.CoinJoin.OwnershipProof> ProveOwnership(RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
			=> new()
			{
				Data = (await SpendableSmartCoin.GenerateOwnershipProofAsync(CoinJoinInputCommitmentData.FromBytes(commitmentData.Data.ToArray()), cancellationToken_)).ToBytes(),
			};

		public Task ReportedSpentAccordingToBackend(CancellationToken cancellationToken_ = default)
			=> SpendableSmartCoin.ReportedSpentAccordingToBackendAsync(cancellationToken_);

		public async Task<(uint, RPC.Bitcoin.WitScript)> Sign(RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default)
		{
			var (i, witness) = await SpendableSmartCoin.SignAsync(Transaction.Load(unsignedTransaction.Data.ToArray(), Network.Main), cancellationToken_);
			return (i, new RPC.Bitcoin.WitScript() { Pushes = witness.Pushes.ToImmutableArray() });
		}
	}

	public record WalletClient(RPC.CoinJoin.IWallet Wallet) : IDisposable
	{
		public void Dispose()
		{
			Wallet.Dispose();
		}

		public async Task<IEnumerable<Client.ISpendableSmartCoin>> GetCoinsAsync(CancellationToken cancellationToken = default)
			=> (await Wallet.Coins(cancellationToken)).Select(c => new SpendableSmartCoinClient(c)).ToImmutableArray();

		public async Task<IEnumerable<Script>> GetSelfSpendDestinationsAsync(int count, CancellationToken cancellationToken = default)
			=> (await Wallet.GenerateSelfSpendScripts(count, cancellationToken)).Select(s => new Script(s.Data.ToArray())).ToImmutableArray();
	}

	public record WalletService(ImmutableArray<ISpendableSmartCoin> Coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> GenerateSelfSpendScripts) : RPC.CoinJoin.IWallet
	{
		Task<IReadOnlyList<RPC.CoinJoin.ISpendableSmartCoin>> RPC.CoinJoin.IWallet.Coins(CancellationToken _)
			=> Task.FromResult(Coins.Select(c => new SpendableSmartCoinService(c) as RPC.CoinJoin.ISpendableSmartCoin).ToImmutableArray() as IReadOnlyList<RPC.CoinJoin.ISpendableSmartCoin>);

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

		public Task<bool> GetInCriticalCoinJoinStateAsync(CancellationToken cancellationToken = default)
			=> Rpc.InCriticalCoinJoinState(cancellationToken);

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

		public Task<bool> InCriticalCoinJoinState(CancellationToken cancellationToken_ = default)
			=> Client.GetInCriticalCoinJoinStateAsync(cancellationToken_);

		public async Task<bool> StartCoinJoin(RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default)
		{
			using WalletClient adaptor = new(wallet);
			var coins = (await adaptor.GetCoinsAsync(cancellationToken_)).ToImmutableArray();
			return await Client.StartCoinJoinAsync(coins, adaptor.GetSelfSpendDestinationsAsync, cancellationToken_);
		}
	}
}
