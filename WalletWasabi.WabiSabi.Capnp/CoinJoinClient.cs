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
	public record SpendableSmartCoinClient(RPC.CoinJoin.ISpendableSmartCoin Rpc) : Client.ISpendableSmartCoin
	{
		private static Coin ConvertCoin(RPC.Bitcoin.Coin coin)
			=> new(new OutPoint(new uint256(coin.Outpoint.Txid.Data.ToArray()), coin.Outpoint.Nout),
				   new TxOut(Money.Satoshis(coin.TxOut.Value.Satoshis), new Script(coin.TxOut.ScriptPubKey.Data)));

		private Lazy<Coin> _coin = new Lazy<Coin>(() => ConvertCoin(Rpc.Coin().Result));
		private Coin Coin => _coin.Value;

		// TODO dispose
		private Lazy<RPC.CoinJoin.CoinState> _state = new Lazy<RPC.CoinJoin.CoinState>(() => Rpc.State().Result);
		private RPC.CoinJoin.CoinState State => _state.Value;

		public TxOut TxOut => Coin.TxOut;

		public OutPoint Outpoint => Coin.Outpoint;
		public int AnonymitySetSizeEstimate => _state.Value.AnonymitySetSizeEstimate.GetValue().Result;

		public bool CoinJoinInProgress { get => State.CoinJoinInProgress.GetValue().Result; set => State.CoinJoinInProgress.SetValue(value).Wait(); }
		public bool SpentAccordingToBackend { get => State.SpentAccordingToBackend.GetValue().Result; set => State.SpentAccordingToBackend.SetValue(value).Wait(); }

		// TODO delete this... omg so fugly.
		public DateTimeOffset? BannedUntilUtc
		{
			get => State.BannedUntilUtc.GetValue().Result switch
			{
				{ which: RPC.CoinJoin.Option<RPC.CoinJoin.DateTimeOffset>.WHICH.Some, Some: { UnixMilliseconds: var milliseconds } } => DateTimeOffset.FromUnixTimeMilliseconds(milliseconds),
				{ which: RPC.CoinJoin.Option<RPC.CoinJoin.DateTimeOffset>.WHICH.None } => null,
				_ => throw new NotImplementedException(),
			};

			set => State.BannedUntilUtc.SetValue(value is null ? new() : new()
			{
				which = RPC.CoinJoin.Option<RPC.CoinJoin.DateTimeOffset>.WHICH.Some,
				Some = new()
				{
					UnixMilliseconds = value.Value.ToUnixTimeMilliseconds()
				}
			});
		}

		public bool IsBanned => State.IsBanned.GetValue().Result;

		public async Task<OwnershipProof> GenerateOwnershipProofAsync(CoinJoinInputCommitmentData commitmentData, CancellationToken cancellationToken = default)
			=> OwnershipProof.FromBytes((await Rpc.ProveOwnership(new RPC.CoinJoin.CommitmentData() { Data = commitmentData.ToBytes() }, cancellationToken)).Data.ToArray());

		public void SetIsBanned()
		{
			State.IsBanned.Refresh().Wait();
		}

		public async Task<(uint, WitScript)> SignAsync(Transaction transaction, CancellationToken cancellationToken = default)
		{
			var (i, witness) = await Rpc.Sign(new RPC.CoinJoin.RawTransaction() { Data = transaction.ToBytes() }, cancellationToken);
			return (i, new WitScript(witness.Pushes.Select(x => x.ToArray())));
		}

		public record SpendableSmartCoinService(Client.ISpendableSmartCoin SpendableSmartCoin) : RPC.CoinJoin.ISpendableSmartCoin
		{
			public Task<RPC.Bitcoin.Coin> Coin(CancellationToken cancellationToken_ = default)
				=> Task.FromResult<RPC.Bitcoin.Coin>(new()
				{
					TxOut = new()
					{
						ScriptPubKey = new() { Data = SpendableSmartCoin.TxOut.ScriptPubKey.ToBytes() },
						Value = new() { Satoshis = SpendableSmartCoin.TxOut.Value },
					},
					Outpoint = new()
					{
						Txid = new() { Data = SpendableSmartCoin.OutPoint.Hash.ToBytes() },
						Nout = SpendableSmartCoin.OutPoint.N,
					}
				});

			public void Dispose()
			{
			}

			public async Task<RPC.CoinJoin.OwnershipProof> ProveOwnership(RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
				=> new()
				{
					Data = (await SpendableSmartCoin.GenerateOwnershipProofAsync(CoinJoinInputCommitmentData.FromBytes(commitmentData.Data.ToArray()), cancellationToken_)).ToBytes(),
				};

			public Task<(uint, RPC.Bitcoin.WitScript)> Sign(RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default)
			{
				throw new NotImplementedException();
			}

			public Task<RPC.CoinJoin.CoinState> State(CancellationToken cancellationToken_ = default)
			{
				throw new NotImplementedException();
			}
		}

		public record WalletClient(RPC.CoinJoin.IWallet Wallet)
		{
			public async Task<IEnumerable<Client.ISpendableSmartCoin>> GetCoinsAsync(CancellationToken cancellationToken = default)
				=> (await Wallet.Coins(cancellationToken)).Select(c => new SpendableSmartCoinClient(c));

			public async Task<IEnumerable<Script>> GetSelfSpendDestinationsAsync(int count, CancellationToken cancellationToken = default)
				=> (await Wallet.GenerateSelfSpendScripts(count, cancellationToken)).Select(s => new Script(s.Data.ToArray()));
		}

		public record WalletService(IEnumerable<ISpendableSmartCoin> Coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> GenerateSelfSpendScripts) : RPC.CoinJoin.IWallet
		{
			async Task<IReadOnlyList<RPC.CoinJoin.ISpendableSmartCoin>> RPC.CoinJoin.IWallet.Coins(CancellationToken _)
				=> Coins.Select(c => new SpendableSmartCoinService(c)).Cast<RPC.CoinJoin.ISpendableSmartCoin>().ToImmutableArray();

			async Task<IReadOnlyList<RPC.Bitcoin.Script>> RPC.CoinJoin.IWallet.GenerateSelfSpendScripts(int count, CancellationToken cancellationToken)
				=> (await GenerateSelfSpendScripts(count, cancellationToken)).Select(s => new RPC.Bitcoin.Script()
				{
					Data = s.ToBytes()
				}).ToImmutableArray();

			public void Dispose()
			{
			}
		}

		public record CoinJoinClientClient(RPC.CoinJoin.ICoinJoinClient Rpc) : Client.ICoinJoinClient
		{
			public Task<bool> GetInCriticalCoinJoinStateAsync(CancellationToken cancellationToken = default)
				=> Rpc.InCriticalCoinJoinState(cancellationToken);

			public Task<bool> StartCoinJoinAsync(IEnumerable<ISpendableSmartCoin> coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> getSelfSpendDestinations, CancellationToken cancellationToken)
			{
				using WalletService wallet = new(coins, getSelfSpendDestinations);
				return Rpc.StartCoinJoin(wallet, cancellationToken);
			}

			public record CoinJoinClientService(Client.ICoinJoinClient Client) : RPC.CoinJoin.ICoinJoinClient
			{
				public void Dispose()
				{
				}

				public Task<bool> InCriticalCoinJoinState(CancellationToken cancellationToken_ = default)
					=> Client.GetInCriticalCoinJoinStateAsync(cancellationToken_);

				public async Task<bool> StartCoinJoin(RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default)
				{
					WalletClient adaptor = new(wallet);
					return await Client.StartCoinJoinAsync(await adaptor.GetCoinsAsync(cancellationToken_), adaptor.GetSelfSpendDestinationsAsync, cancellationToken_);
				}
			}
		}
	}
}
