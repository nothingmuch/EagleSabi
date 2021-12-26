using Capnp;
using Capnp.Rpc;

namespace WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin
{
	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xac54b67ef781e801UL)]
	public class CommitmentData : ICapnpSerializable
	{
		public const UInt64 typeId = 0xac54b67ef781e801UL;

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			Data = reader.Data;
			applyDefaults();
		}

		public void serialize(WRITER writer)
		{
			writer.Data.Init(Data);
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public IReadOnlyList<byte> Data
		{
			get;
			set;
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public IReadOnlyList<byte> Data => ctx.ReadList(0).CastByte();
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(0, 1);
			}

			public ListOfPrimitivesSerializer<byte> Data
			{
				get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
				set => Link(0, value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xacc0a137bd971057UL)]
	public class OwnershipProof : ICapnpSerializable
	{
		public const UInt64 typeId = 0xacc0a137bd971057UL;

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			Data = reader.Data;
			applyDefaults();
		}

		public void serialize(WRITER writer)
		{
			writer.Data.Init(Data);
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public IReadOnlyList<byte> Data
		{
			get;
			set;
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public IReadOnlyList<byte> Data => ctx.ReadList(0).CastByte();
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(0, 1);
			}

			public ListOfPrimitivesSerializer<byte> Data
			{
				get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
				set => Link(0, value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc26acb54a7b0b3a1UL)]
	public class RawTransaction : ICapnpSerializable
	{
		public const UInt64 typeId = 0xc26acb54a7b0b3a1UL;

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			Data = reader.Data;
			applyDefaults();
		}

		public void serialize(WRITER writer)
		{
			writer.Data.Init(Data);
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public IReadOnlyList<byte> Data
		{
			get;
			set;
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public IReadOnlyList<byte> Data => ctx.ReadList(0).CastByte();
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(0, 1);
			}

			public ListOfPrimitivesSerializer<byte> Data
			{
				get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
				set => Link(0, value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL), Proxy(typeof(SpendableCoin_Proxy)), Skeleton(typeof(SpendableCoin_Skeleton))]
	public interface ISpendableCoin : IDisposable
	{
		Task<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin> Coin(CancellationToken cancellationToken_ = default);

		Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof> ProveOwnership(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default);

		Task<(uint, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript)> Sign(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL)]
	public class SpendableCoin_Proxy : Proxy, ISpendableCoin
	{
		public async Task<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin> Coin(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Coin.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Coin()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Coin>(d_);
				return (r_.Coin);
			}
		}

		public async Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof> ProveOwnership(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_ProveOwnership.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_ProveOwnership()
			{ CommitmentData = commitmentData };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_ProveOwnership>(d_);
				return (r_.OwnershipProof);
			}
		}

		public async Task<(uint, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript)> Sign(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Sign.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Sign()
			{ UnsignedTransaction = unsignedTransaction };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 2, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Sign>(d_);
				return (r_.Index, r_.Witness);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL)]
	public class SpendableCoin_Skeleton : Skeleton<ISpendableCoin>
	{
		public SpendableCoin_Skeleton()
		{
			SetMethodTable(Coin, ProveOwnership, Sign);
		}

		public override ulong InterfaceId => 15070211874704538306UL;

		private Task<AnswerOrCounterquestion> Coin(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.Coin(cancellationToken_), coin =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Coin.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Coin { Coin = coin };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}

		private Task<AnswerOrCounterquestion> ProveOwnership(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_ProveOwnership>(d_);
				return Impatient.MaybeTailCall(Impl.ProveOwnership(in_.CommitmentData, cancellationToken_), ownershipProof =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_ProveOwnership.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_ProveOwnership { OwnershipProof = ownershipProof };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}

		private Task<AnswerOrCounterquestion> Sign(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Sign>(d_);
				return Impatient.MaybeTailCall(Impl.Sign(in_.UnsignedTransaction, cancellationToken_), (index, witness) =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Sign.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Sign { Index = index, Witness = witness };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class SpendableCoin
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xce17d91bfca7720fUL)]
		public class Params_Coin : ICapnpSerializable
		{
			public const UInt64 typeId = 0xce17d91bfca7720fUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xce34df608f01b358UL)]
		public class Result_Coin : ICapnpSerializable
		{
			public const UInt64 typeId = 0xce34df608f01b358UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Coin = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin>(reader.Coin);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				Coin?.serialize(writer.Coin);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin Coin
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.READER Coin => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.WRITER Coin
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.WRITER>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa071cde82530e210UL)]
		public class Params_ProveOwnership : ICapnpSerializable
		{
			public const UInt64 typeId = 0xa071cde82530e210UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				CommitmentData = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData>(reader.CommitmentData);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				CommitmentData?.serialize(writer.CommitmentData);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData CommitmentData
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.READER CommitmentData => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.WRITER CommitmentData
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.WRITER>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc33d14bc6de8a85cUL)]
		public class Result_ProveOwnership : ICapnpSerializable
		{
			public const UInt64 typeId = 0xc33d14bc6de8a85cUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				OwnershipProof = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof>(reader.OwnershipProof);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				OwnershipProof?.serialize(writer.OwnershipProof);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof OwnershipProof
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.READER OwnershipProof => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.WRITER OwnershipProof
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.WRITER>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe522529ac314db45UL)]
		public class Params_Sign : ICapnpSerializable
		{
			public const UInt64 typeId = 0xe522529ac314db45UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				UnsignedTransaction = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction>(reader.UnsignedTransaction);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				UnsignedTransaction?.serialize(writer.UnsignedTransaction);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction UnsignedTransaction
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.READER UnsignedTransaction => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.WRITER UnsignedTransaction
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.WRITER>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xaef6bb89c0c7e7f2UL)]
		public class Result_Sign : ICapnpSerializable
		{
			public const UInt64 typeId = 0xaef6bb89c0c7e7f2UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Index = reader.Index;
				Witness = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript>(reader.Witness);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Index = Index;
				Witness?.serialize(writer.Witness);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public uint Index
			{
				get;
				set;
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript Witness
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public uint Index => ctx.ReadDataUInt(0UL, 0U);
				public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.READER Witness => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 1);
				}

				public uint Index
				{
					get => this.ReadDataUInt(0UL, 0U);
					set => this.WriteData(0UL, value, 0U);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.WRITER Witness
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.WRITER>(0);
					set => Link(0, value);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x89eefd5133657335UL)]
	public class DateTimeOffset : ICapnpSerializable
	{
		public const UInt64 typeId = 0x89eefd5133657335UL;

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			UnixMilliseconds = reader.UnixMilliseconds;
			applyDefaults();
		}

		public void serialize(WRITER writer)
		{
			writer.UnixMilliseconds = UnixMilliseconds;
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public long UnixMilliseconds
		{
			get;
			set;
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public long UnixMilliseconds => ctx.ReadDataLong(0UL, 0L);
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(1, 0);
			}

			public long UnixMilliseconds
			{
				get => this.ReadDataLong(0UL, 0L);
				set => this.WriteData(0UL, value, 0L);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8da02c6a926761c6UL), Proxy(typeof(IntProperty_Proxy)), Skeleton(typeof(IntProperty_Skeleton))]
	public interface IIntProperty : IDisposable
	{
		Task<int> GetValue(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8da02c6a926761c6UL)]
	public class IntProperty_Proxy : Proxy, IIntProperty
	{
		public async Task<int> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IntProperty.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IntProperty.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(10205205591855948230UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IntProperty.Result_GetValue>(d_);
				return (r_.Value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8da02c6a926761c6UL)]
	public class IntProperty_Skeleton : Skeleton<IIntProperty>
	{
		public IntProperty_Skeleton()
		{
			SetMethodTable(GetValue);
		}

		public override ulong InterfaceId => 10205205591855948230UL;

		private Task<AnswerOrCounterquestion> GetValue(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.GetValue(cancellationToken_), value =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IntProperty.Result_GetValue.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IntProperty.Result_GetValue { Value = value };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class IntProperty
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd8830a8b34bbe46dUL)]
		public class Params_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xd8830a8b34bbe46dUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xde9aa36371a68f1bUL)]
		public class Result_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xde9aa36371a68f1bUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Value = reader.Value;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Value = Value;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public int Value
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public int Value => ctx.ReadDataInt(0UL, 0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public int Value
				{
					get => this.ReadDataInt(0UL, 0);
					set => this.WriteData(0UL, value, 0);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb28a940ed0f3b0edUL), Proxy(typeof(BoolProperty_Proxy)), Skeleton(typeof(BoolProperty_Skeleton))]
	public interface IBoolProperty : IDisposable
	{
		Task<bool> GetValue(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb28a940ed0f3b0edUL)]
	public class BoolProperty_Proxy : Proxy, IBoolProperty
	{
		public async Task<bool> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(12865258076893327597UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Result_GetValue>(d_);
				return (r_.Value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb28a940ed0f3b0edUL)]
	public class BoolProperty_Skeleton : Skeleton<IBoolProperty>
	{
		public BoolProperty_Skeleton()
		{
			SetMethodTable(GetValue);
		}

		public override ulong InterfaceId => 12865258076893327597UL;

		private Task<AnswerOrCounterquestion> GetValue(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.GetValue(cancellationToken_), value =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Result_GetValue.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Result_GetValue { Value = value };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class BoolProperty
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe82f4e3d895aa684UL)]
		public class Params_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xe82f4e3d895aa684UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8caf8a4db7f0f882UL)]
		public class Result_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0x8caf8a4db7f0f882UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Value = reader.Value;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Value = Value;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public bool Value
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public bool Value => ctx.ReadDataBool(0UL, false);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public bool Value
				{
					get => this.ReadDataBool(0UL, false);
					set => this.WriteData(0UL, value, false);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x972325b127da679bUL), Proxy(typeof(MutableBool_Proxy)), Skeleton(typeof(MutableBool_Skeleton))]
	public interface IMutableBool : WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty
	{
		Task SetValue(bool value, CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x972325b127da679bUL)]
	public class MutableBool_Proxy : Proxy, IMutableBool
	{
		public async Task SetValue(bool value, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.MutableBool.Params_SetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.MutableBool.Params_SetValue()
			{ Value = value };
			arg_?.serialize(in_);
			using (var d_ = await Call(10890589766720055195UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.MutableBool.Result_SetValue>(d_);
				return;
			}
		}

		public async Task<bool> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(12865258076893327597UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Result_GetValue>(d_);
				return (r_.Value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x972325b127da679bUL)]
	public class MutableBool_Skeleton : Skeleton<IMutableBool>
	{
		public MutableBool_Skeleton()
		{
			SetMethodTable(SetValue);
		}

		public override ulong InterfaceId => 10890589766720055195UL;

		private async Task<AnswerOrCounterquestion> SetValue(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.MutableBool.Params_SetValue>(d_);
				await Impl.SetValue(in_.Value, cancellationToken_);
				var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.MutableBool.Result_SetValue.WRITER>();
				return s_;
			}
		}
	}

	public static class MutableBool
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x89efce71559b0e04UL)]
		public class Params_SetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0x89efce71559b0e04UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Value = reader.Value;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Value = Value;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public bool Value
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public bool Value => ctx.ReadDataBool(0UL, false);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public bool Value
				{
					get => this.ReadDataBool(0UL, false);
					set => this.WriteData(0UL, value, false);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcf812e623658ba51UL)]
		public class Result_SetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xcf812e623658ba51UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbf502c18735fc57cUL)]
	public class Option<TT> : ICapnpSerializable where TT : class
	{
		public const UInt64 typeId = 0xbf502c18735fc57cUL;

		public enum WHICH : ushort
		{
			None = 0,
			Some = 1,
			undefined = 65535
		}

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			switch (reader.which)
			{
				case WHICH.None:
					which = reader.which;
					break;

				case WHICH.Some:
					Some = CapnpSerializable.Create<TT>(reader.Some);
					break;
			}

			applyDefaults();
		}

		private WHICH _which = WHICH.undefined;
		private object _content;

		public WHICH which
		{
			get => _which;
			set
			{
				if (value == _which)
					return;
				_which = value;
				switch (value)
				{
					case WHICH.None:
						break;

					case WHICH.Some:
						_content = null;
						break;
				}
			}
		}

		public void serialize(WRITER writer)
		{
			writer.which = which;
			switch (which)
			{
				case WHICH.None:
					break;

				case WHICH.Some:
					writer.Some.SetObject(Some);
					break;
			}
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public TT Some
		{
			get => _which == WHICH.Some ? (TT)_content : null;
			set
			{
				_which = WHICH.Some;
				_content = value;
			}
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public WHICH which => (WHICH)ctx.ReadDataUShort(0U, (ushort)0);
			public DeserializerState Some => which == WHICH.Some ? ctx.StructReadPointer(0) : default;
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(1, 1);
			}

			public WHICH which
			{
				get => (WHICH)this.ReadDataUShort(0U, (ushort)0);
				set => this.WriteData(0U, (ushort)value, (ushort)0);
			}

			public DynamicSerializerState Some
			{
				get => which == WHICH.Some ? BuildPointer<DynamicSerializerState>(0) : default;
				set => Link(0, value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8366a230718d58b0UL), Proxy(typeof(Property_Proxy<>)), Skeleton(typeof(Property_Skeleton<>))]
	public interface IProperty<TT> : IDisposable where TT : class
	{
		Task<TT> GetValue(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8366a230718d58b0UL)]
	public class Property_Proxy<TT> : Proxy, IProperty<TT> where TT : class
	{
		public Task<TT> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			return Impatient.MakePipelineAware(Call(9468433595540265136UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
			{
				using (d_)
				{
					var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Result_GetValue>(d_);
					return (r_.Value);
				}
			}

			);
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8366a230718d58b0UL)]
	public class Property_Skeleton<TT> : Skeleton<IProperty<TT>> where TT : class
	{
		public Property_Skeleton()
		{
			SetMethodTable(GetValue);
		}

		public override ulong InterfaceId => 9468433595540265136UL;

		private Task<AnswerOrCounterquestion> GetValue(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.GetValue(cancellationToken_), value =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Result_GetValue.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Result_GetValue { Value = value };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class Property<TT>
		where TT : class
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb8e67d69868db45bUL)]
		public class Params_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xb8e67d69868db45bUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd9794d752518bdceUL)]
		public class Result_GetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xd9794d752518bdceUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Value = CapnpSerializable.Create<TT>(reader.Value);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Value.SetObject(Value);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public TT Value
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public DeserializerState Value => ctx.StructReadPointer(0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public DynamicSerializerState Value
				{
					get => BuildPointer<DynamicSerializerState>(0);
					set => Link(0, value);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa7530024bfc6fe78UL), Proxy(typeof(Mutable_Proxy<>)), Skeleton(typeof(Mutable_Skeleton<>))]
	public interface IMutable<TT> : WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IProperty<TT> where TT : class
	{
		Task SetValue(TT value, CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa7530024bfc6fe78UL)]
	public class Mutable_Proxy<TT> : Proxy, IMutable<TT> where TT : class
	{
		public async Task SetValue(TT value, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Mutable<TT>.Params_SetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Mutable<TT>.Params_SetValue()
			{ Value = value };
			arg_?.serialize(in_);
			using (var d_ = await Call(12056980785237261944UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Mutable<TT>.Result_SetValue>(d_);
				return;
			}
		}

		public Task<TT> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			return Impatient.MakePipelineAware(Call(9468433595540265136UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
			{
				using (d_)
				{
					var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Property<TT>.Result_GetValue>(d_);
					return (r_.Value);
				}
			}

			);
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa7530024bfc6fe78UL)]
	public class Mutable_Skeleton<TT> : Skeleton<IMutable<TT>> where TT : class
	{
		public Mutable_Skeleton()
		{
			SetMethodTable(SetValue);
		}

		public override ulong InterfaceId => 12056980785237261944UL;

		private async Task<AnswerOrCounterquestion> SetValue(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Mutable<TT>.Params_SetValue>(d_);
				await Impl.SetValue(in_.Value, cancellationToken_);
				var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Mutable<TT>.Result_SetValue.WRITER>();
				return s_;
			}
		}
	}

	public static class Mutable<TT>
		where TT : class
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xacad8617bd7e0edbUL)]
		public class Params_SetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xacad8617bd7e0edbUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Value = CapnpSerializable.Create<TT>(reader.Value);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Value.SetObject(Value);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public TT Value
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public DeserializerState Value => ctx.StructReadPointer(0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public DynamicSerializerState Value
				{
					get => BuildPointer<DynamicSerializerState>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc77883678ce6fb4eUL)]
		public class Result_SetValue : ICapnpSerializable
		{
			public const UInt64 typeId = 0xc77883678ce6fb4eUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbc9ba67a4f8dc1eaUL), Proxy(typeof(HorribleIsBannedProperty_Proxy)), Skeleton(typeof(HorribleIsBannedProperty_Skeleton))]
	public interface IHorribleIsBannedProperty : WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty
	{
		Task Refresh(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbc9ba67a4f8dc1eaUL)]
	public class HorribleIsBannedProperty_Proxy : Proxy, IHorribleIsBannedProperty
	{
		public async Task Refresh(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.HorribleIsBannedProperty.Params_Refresh.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.HorribleIsBannedProperty.Params_Refresh()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(13590639344771514858UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.HorribleIsBannedProperty.Result_Refresh>(d_);
				return;
			}
		}

		public async Task<bool> GetValue(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Params_GetValue()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(12865258076893327597UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.BoolProperty.Result_GetValue>(d_);
				return (r_.Value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbc9ba67a4f8dc1eaUL)]
	public class HorribleIsBannedProperty_Skeleton : Skeleton<IHorribleIsBannedProperty>
	{
		public HorribleIsBannedProperty_Skeleton()
		{
			SetMethodTable(Refresh);
		}

		public override ulong InterfaceId => 13590639344771514858UL;

		private async Task<AnswerOrCounterquestion> Refresh(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				await Impl.Refresh(cancellationToken_);
				var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.HorribleIsBannedProperty.Result_Refresh.WRITER>();
				return s_;
			}
		}
	}

	public static class HorribleIsBannedProperty
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb85058a53b75e150UL)]
		public class Params_Refresh : ICapnpSerializable
		{
			public const UInt64 typeId = 0xb85058a53b75e150UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8a1f20ace3ebd7ecUL)]
		public class Result_Refresh : ICapnpSerializable
		{
			public const UInt64 typeId = 0x8a1f20ace3ebd7ecUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa638ffbd1f30bbcaUL)]
	public class CoinState : ICapnpSerializable
	{
		public const UInt64 typeId = 0xa638ffbd1f30bbcaUL;

		void ICapnpSerializable.Deserialize(DeserializerState arg_)
		{
			var reader = READER.create(arg_);
			AnonymitySetSizeEstimate = reader.AnonymitySetSizeEstimate;
			CoinJoinInProgress = reader.CoinJoinInProgress;
			SpentAccordingToBackend = reader.SpentAccordingToBackend;
			BannedUntilUtc = reader.BannedUntilUtc;
			IsBanned = reader.IsBanned;
			IsConfirmed = reader.IsConfirmed;
			applyDefaults();
		}

		public void serialize(WRITER writer)
		{
			writer.AnonymitySetSizeEstimate = AnonymitySetSizeEstimate;
			writer.CoinJoinInProgress = CoinJoinInProgress;
			writer.SpentAccordingToBackend = SpentAccordingToBackend;
			writer.BannedUntilUtc = BannedUntilUtc;
			writer.IsBanned = IsBanned;
			writer.IsConfirmed = IsConfirmed;
		}

		void ICapnpSerializable.Serialize(SerializerState arg_)
		{
			serialize(arg_.Rewrap<WRITER>());
		}

		public void applyDefaults()
		{
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty AnonymitySetSizeEstimate
		{
			get;
			set;
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool CoinJoinInProgress
		{
			get;
			set;
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool SpentAccordingToBackend
		{
			get;
			set;
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>> BannedUntilUtc
		{
			get;
			set;
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty IsBanned
		{
			get;
			set;
		}

		public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty IsConfirmed
		{
			get;
			set;
		}

		public struct READER
		{
			private readonly DeserializerState ctx;

			public READER(DeserializerState ctx)
			{
				this.ctx = ctx;
			}

			public static READER create(DeserializerState ctx) => new READER(ctx);

			public static implicit operator DeserializerState(READER reader) => reader.ctx;

			public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty AnonymitySetSizeEstimate => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty>(0);
			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool CoinJoinInProgress => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(1);
			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool SpentAccordingToBackend => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(2);
			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>> BannedUntilUtc => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>>>(3);
			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty IsBanned => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty>(4);
			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty IsConfirmed => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty>(5);
		}

		public class WRITER : SerializerState
		{
			public WRITER()
			{
				this.SetStruct(0, 6);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty AnonymitySetSizeEstimate
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty>(0);
				set => LinkObject(0, value);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool CoinJoinInProgress
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(1);
				set => LinkObject(1, value);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool SpentAccordingToBackend
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(2);
				set => LinkObject(2, value);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>> BannedUntilUtc
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>>>(3);
				set => LinkObject(3, value);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty IsBanned
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty>(4);
				set => LinkObject(4, value);
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty IsConfirmed
			{
				get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty>(5);
				set => LinkObject(5, value);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xeb0f2fdba3822545UL), Proxy(typeof(SpendableSmartCoin_Proxy)), Skeleton(typeof(SpendableSmartCoin_Skeleton))]
	public interface ISpendableSmartCoin : WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableCoin
	{
		Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> State(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xeb0f2fdba3822545UL)]
	public class SpendableSmartCoin_Proxy : Proxy, ISpendableSmartCoin
	{
		public Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> State(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableSmartCoin.Params_State.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableSmartCoin.Params_State()
			{ };
			arg_?.serialize(in_);
			return Impatient.MakePipelineAware(Call(16937809343951283525UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
			{
				using (d_)
				{
					var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableSmartCoin.Result_State>(d_);
					return (r_.State);
				}
			}

			);
		}

		public async Task<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin> Coin(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Coin.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Coin()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Coin>(d_);
				return (r_.Coin);
			}
		}

		public async Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof> ProveOwnership(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_ProveOwnership.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_ProveOwnership()
			{ CommitmentData = commitmentData };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_ProveOwnership>(d_);
				return (r_.OwnershipProof);
			}
		}

		public async Task<(uint, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript)> Sign(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Sign.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Params_Sign()
			{ UnsignedTransaction = unsignedTransaction };
			arg_?.serialize(in_);
			using (var d_ = await Call(15070211874704538306UL, 2, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.Result_Sign>(d_);
				return (r_.Index, r_.Witness);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xeb0f2fdba3822545UL)]
	public class SpendableSmartCoin_Skeleton : Skeleton<ISpendableSmartCoin>
	{
		public SpendableSmartCoin_Skeleton()
		{
			SetMethodTable(State);
		}

		public override ulong InterfaceId => 16937809343951283525UL;

		private Task<AnswerOrCounterquestion> State(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.State(cancellationToken_), state =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableSmartCoin.Result_State.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableSmartCoin.Result_State { State = state };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class SpendableSmartCoin
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc4c7548bc28165d6UL)]
		public class Params_State : ICapnpSerializable
		{
			public const UInt64 typeId = 0xc4c7548bc28165d6UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb3d575606afe841fUL)]
		public class Result_State : ICapnpSerializable
		{
			public const UInt64 typeId = 0xb3d575606afe841fUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				State = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState>(reader.State);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				State?.serialize(writer.State);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState State
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState.READER State => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState.WRITER State
				{
					get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState.WRITER>(0);
					set => Link(0, value);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee0c45dd09eb9d61UL), Proxy(typeof(Wallet_Proxy)), Skeleton(typeof(Wallet_Skeleton))]
	public interface IWallet : IDisposable
	{
		Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin>> Coins(CancellationToken cancellationToken_ = default);

		Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>> GenerateSelfSpendScripts(int count, CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee0c45dd09eb9d61UL)]
	public class Wallet_Proxy : Proxy, IWallet
	{
		public Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin>> Coins(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_Coins.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_Coins()
			{ };
			arg_?.serialize(in_);
			return Impatient.MakePipelineAware(Call(17153161896403901793UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
			{
				using (d_)
				{
					var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_Coins>(d_);
					return (r_.Coins);
				}
			}

			);
		}

		public async Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>> GenerateSelfSpendScripts(int count, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts()
			{ Count = count };
			arg_?.serialize(in_);
			using (var d_ = await Call(17153161896403901793UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GenerateSelfSpendScripts>(d_);
				return (r_.ScriptPubKeys);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee0c45dd09eb9d61UL)]
	public class Wallet_Skeleton : Skeleton<IWallet>
	{
		public Wallet_Skeleton()
		{
			SetMethodTable(Coins, GenerateSelfSpendScripts);
		}

		public override ulong InterfaceId => 17153161896403901793UL;

		private Task<AnswerOrCounterquestion> Coins(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.Coins(cancellationToken_), coins =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_Coins.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_Coins { Coins = coins };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}

		private Task<AnswerOrCounterquestion> GenerateSelfSpendScripts(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts>(d_);
				return Impatient.MaybeTailCall(Impl.GenerateSelfSpendScripts(in_.Count, cancellationToken_), scriptPubKeys =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GenerateSelfSpendScripts.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GenerateSelfSpendScripts { ScriptPubKeys = scriptPubKeys };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class Wallet
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe95c00201539d9bdUL)]
		public class Params_Coins : ICapnpSerializable
		{
			public const UInt64 typeId = 0xe95c00201539d9bdUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe384f3d2a9715a65UL)]
		public class Result_Coins : ICapnpSerializable
		{
			public const UInt64 typeId = 0xe384f3d2a9715a65UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Coins = reader.Coins;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Coins.Init(Coins);
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin> Coins
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin> Coins => ctx.ReadCapList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin>(0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public ListOfCapsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin> Coins
				{
					get => BuildPointer<ListOfCapsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendableSmartCoin>>(0);
					set => Link(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf4791eaef64d5a1aUL)]
		public class Params_GenerateSelfSpendScripts : ICapnpSerializable
		{
			public const UInt64 typeId = 0xf4791eaef64d5a1aUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Count = reader.Count;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Count = Count;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public int Count
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public int Count => ctx.ReadDataInt(0UL, 0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public int Count
				{
					get => this.ReadDataInt(0UL, 0);
					set => this.WriteData(0UL, value, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdf549f3521757baaUL)]
		public class Result_GenerateSelfSpendScripts : ICapnpSerializable
		{
			public const UInt64 typeId = 0xdf549f3521757baaUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				ScriptPubKeys = reader.ScriptPubKeys?.ToReadOnlyList(_ => CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>(_));
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.ScriptPubKeys.Init(ScriptPubKeys, (_s1, _v1) => _v1?.serialize(_s1));
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script> ScriptPubKeys
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER> ScriptPubKeys => ctx.ReadList(0).Cast(WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER.create);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public ListOfStructsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.WRITER> ScriptPubKeys
				{
					get => BuildPointer<ListOfStructsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.WRITER>>(0);
					set => Link(0, value);
				}
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL), Proxy(typeof(CoinJoinClient_Proxy)), Skeleton(typeof(CoinJoinClient_Skeleton))]
	public interface ICoinJoinClient : IDisposable
	{
		Task<bool> StartCoinJoin(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default);

		Task<bool> InCriticalCoinJoinState(CancellationToken cancellationToken_ = default);
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL)]
	public class CoinJoinClient_Proxy : Proxy, ICoinJoinClient
	{
		public async Task<bool> StartCoinJoin(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Params_StartCoinJoin.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Params_StartCoinJoin()
			{ Wallet = wallet };
			arg_?.serialize(in_);
			using (var d_ = await Call(14611412366222466594UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_StartCoinJoin>(d_);
				return (r_.Succeeded);
			}
		}

		public async Task<bool> InCriticalCoinJoinState(CancellationToken cancellationToken_ = default)
		{
			var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Params_InCriticalCoinJoinState.WRITER>();
			var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Params_InCriticalCoinJoinState()
			{ };
			arg_?.serialize(in_);
			using (var d_ = await Call(14611412366222466594UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
			{
				var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_InCriticalCoinJoinState>(d_);
				return (r_.InCritical);
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL)]
	public class CoinJoinClient_Skeleton : Skeleton<ICoinJoinClient>
	{
		public CoinJoinClient_Skeleton()
		{
			SetMethodTable(StartCoinJoin, InCriticalCoinJoinState);
		}

		public override ulong InterfaceId => 14611412366222466594UL;

		private Task<AnswerOrCounterquestion> StartCoinJoin(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Params_StartCoinJoin>(d_);
				return Impatient.MaybeTailCall(Impl.StartCoinJoin(in_.Wallet, cancellationToken_), succeeded =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_StartCoinJoin.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_StartCoinJoin { Succeeded = succeeded };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}

		private Task<AnswerOrCounterquestion> InCriticalCoinJoinState(DeserializerState d_, CancellationToken cancellationToken_)
		{
			using (d_)
			{
				return Impatient.MaybeTailCall(Impl.InCriticalCoinJoinState(cancellationToken_), inCritical =>
				{
					var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_InCriticalCoinJoinState.WRITER>();
					var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinClient.Result_InCriticalCoinJoinState { InCritical = inCritical };
					r_.serialize(s_);
					return s_;
				}

				);
			}
		}
	}

	public static class CoinJoinClient
	{
		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe0a6e0b579bbb5a9UL)]
		public class Params_StartCoinJoin : ICapnpSerializable
		{
			public const UInt64 typeId = 0xe0a6e0b579bbb5a9UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Wallet = reader.Wallet;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Wallet = Wallet;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet Wallet
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet Wallet => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet>(0);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 1);
				}

				public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet Wallet
				{
					get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet>(0);
					set => LinkObject(0, value);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd1b8bef17476544aUL)]
		public class Result_StartCoinJoin : ICapnpSerializable
		{
			public const UInt64 typeId = 0xd1b8bef17476544aUL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				Succeeded = reader.Succeeded;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.Succeeded = Succeeded;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public bool Succeeded
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public bool Succeeded => ctx.ReadDataBool(0UL, false);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public bool Succeeded
				{
					get => this.ReadDataBool(0UL, false);
					set => this.WriteData(0UL, value, false);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xebdba9fd0587d4e1UL)]
		public class Params_InCriticalCoinJoinState : ICapnpSerializable
		{
			public const UInt64 typeId = 0xebdba9fd0587d4e1UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(0, 0);
				}
			}
		}

		[System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee6d411c80558442UL)]
		public class Result_InCriticalCoinJoinState : ICapnpSerializable
		{
			public const UInt64 typeId = 0xee6d411c80558442UL;

			void ICapnpSerializable.Deserialize(DeserializerState arg_)
			{
				var reader = READER.create(arg_);
				InCritical = reader.InCritical;
				applyDefaults();
			}

			public void serialize(WRITER writer)
			{
				writer.InCritical = InCritical;
			}

			void ICapnpSerializable.Serialize(SerializerState arg_)
			{
				serialize(arg_.Rewrap<WRITER>());
			}

			public void applyDefaults()
			{
			}

			public bool InCritical
			{
				get;
				set;
			}

			public struct READER
			{
				private readonly DeserializerState ctx;

				public READER(DeserializerState ctx)
				{
					this.ctx = ctx;
				}

				public static READER create(DeserializerState ctx) => new READER(ctx);

				public static implicit operator DeserializerState(READER reader) => reader.ctx;

				public static implicit operator READER(DeserializerState ctx) => new READER(ctx);

				public bool InCritical => ctx.ReadDataBool(0UL, false);
			}

			public class WRITER : SerializerState
			{
				public WRITER()
				{
					this.SetStruct(1, 0);
				}

				public bool InCritical
				{
					get => this.ReadDataBool(0UL, false);
					set => this.WriteData(0UL, value, false);
				}
			}
		}
	}

	/*
		public static partial class PipeliningSupportExtensions_coinjoin
		{
			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_IsConfirmed = new MemberAccessPath(0U, 5U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty State_IsConfirmed(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.IsConfirmed;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IBoolProperty>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_IsConfirmed, AwaitProxy()));
			}

			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_IsBanned = new MemberAccessPath(0U, 4U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty State_IsBanned(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.IsBanned;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IHorribleIsBannedProperty>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_IsBanned, AwaitProxy()));
			}

			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_BannedUntilUtc = new MemberAccessPath(0U, 3U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>> State_BannedUntilUtc(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.BannedUntilUtc;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>>)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutable<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Option<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>>>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_BannedUntilUtc, AwaitProxy()));
			}

			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_SpentAccordingToBackend = new MemberAccessPath(0U, 2U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool State_SpentAccordingToBackend(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.SpentAccordingToBackend;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_SpentAccordingToBackend, AwaitProxy()));
			}

			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_CoinJoinInProgress = new MemberAccessPath(0U, 1U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool State_CoinJoinInProgress(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.CoinJoinInProgress;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IMutableBool>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_CoinJoinInProgress, AwaitProxy()));
			}

			static readonly MemberAccessPath Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_AnonymitySetSizeEstimate = new MemberAccessPath(0U, 0U);
			public static WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty State_AnonymitySetSizeEstimate(this Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinState> task)
			{
				async Task<IDisposable> AwaitProxy() => (await task).State?.AnonymitySetSizeEstimate;
				return (WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty)CapabilityReflection.CreateProxy<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IIntProperty>(Impatient.Access(task, Path_WalletWasabi_WabiSabi_Capnp_RPC_CoinJoin_SpendableSmartCoin_state_State_AnonymitySetSizeEstimate, AwaitProxy()));
			}
		}
	*/
}
