using Capnp;
using Capnp.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CapnpGen
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
            readonly DeserializerState ctx;
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
            readonly DeserializerState ctx;
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
        Task<CapnpGen.Coin> Coin(CancellationToken cancellationToken_ = default);
        Task<CapnpGen.OwnershipProof> CreateOwnershipProof(CapnpGen.CommitmentData commitmentData, CancellationToken cancellationToken_ = default);
        Task<CapnpGen.WitScript> Sign(IReadOnlyList<byte> unsignedTransaction, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL)]
    public class SpendableCoin_Proxy : Proxy, ISpendableCoin
    {
        public async Task<CapnpGen.Coin> Coin(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Params_Coin.WRITER>();
            var arg_ = new CapnpGen.SpendableCoin.Params_Coin()
            {};
            arg_?.serialize(in_);
            using (var d_ = await Call(15070211874704538306UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<CapnpGen.SpendableCoin.Result_Coin>(d_);
                return (r_.Coin);
            }
        }

        public async Task<CapnpGen.OwnershipProof> CreateOwnershipProof(CapnpGen.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Params_CreateOwnershipProof.WRITER>();
            var arg_ = new CapnpGen.SpendableCoin.Params_CreateOwnershipProof()
            {CommitmentData = commitmentData};
            arg_?.serialize(in_);
            using (var d_ = await Call(15070211874704538306UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<CapnpGen.SpendableCoin.Result_CreateOwnershipProof>(d_);
                return (r_.OwnershipProof);
            }
        }

        public async Task<CapnpGen.WitScript> Sign(IReadOnlyList<byte> unsignedTransaction, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Params_Sign.WRITER>();
            var arg_ = new CapnpGen.SpendableCoin.Params_Sign()
            {UnsignedTransaction = unsignedTransaction};
            arg_?.serialize(in_);
            using (var d_ = await Call(15070211874704538306UL, 2, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<CapnpGen.SpendableCoin.Result_Sign>(d_);
                return (r_.Witness);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL)]
    public class SpendableCoin_Skeleton : Skeleton<ISpendableCoin>
    {
        public SpendableCoin_Skeleton()
        {
            SetMethodTable(Coin, CreateOwnershipProof, Sign);
        }

        public override ulong InterfaceId => 15070211874704538306UL;
        Task<AnswerOrCounterquestion> Coin(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                return Impatient.MaybeTailCall(Impl.Coin(cancellationToken_), coin =>
                {
                    var s_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Result_Coin.WRITER>();
                    var r_ = new CapnpGen.SpendableCoin.Result_Coin{Coin = coin};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }

        Task<AnswerOrCounterquestion> CreateOwnershipProof(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<CapnpGen.SpendableCoin.Params_CreateOwnershipProof>(d_);
                return Impatient.MaybeTailCall(Impl.CreateOwnershipProof(in_.CommitmentData, cancellationToken_), ownershipProof =>
                {
                    var s_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Result_CreateOwnershipProof.WRITER>();
                    var r_ = new CapnpGen.SpendableCoin.Result_CreateOwnershipProof{OwnershipProof = ownershipProof};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }

        Task<AnswerOrCounterquestion> Sign(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<CapnpGen.SpendableCoin.Params_Sign>(d_);
                return Impatient.MaybeTailCall(Impl.Sign(in_.UnsignedTransaction, cancellationToken_), witness =>
                {
                    var s_ = SerializerState.CreateForRpc<CapnpGen.SpendableCoin.Result_Sign.WRITER>();
                    var r_ = new CapnpGen.SpendableCoin.Result_Sign{Witness = witness};
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
                readonly DeserializerState ctx;
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
                Coin = CapnpSerializable.Create<CapnpGen.Coin>(reader.Coin);
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

            public CapnpGen.Coin Coin
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public CapnpGen.Coin.READER Coin => ctx.ReadStruct(0, CapnpGen.Coin.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public CapnpGen.Coin.WRITER Coin
                {
                    get => BuildPointer<CapnpGen.Coin.WRITER>(0);
                    set => Link(0, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa071cde82530e210UL)]
        public class Params_CreateOwnershipProof : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa071cde82530e210UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                CommitmentData = CapnpSerializable.Create<CapnpGen.CommitmentData>(reader.CommitmentData);
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

            public CapnpGen.CommitmentData CommitmentData
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public CapnpGen.CommitmentData.READER CommitmentData => ctx.ReadStruct(0, CapnpGen.CommitmentData.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public CapnpGen.CommitmentData.WRITER CommitmentData
                {
                    get => BuildPointer<CapnpGen.CommitmentData.WRITER>(0);
                    set => Link(0, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc33d14bc6de8a85cUL)]
        public class Result_CreateOwnershipProof : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc33d14bc6de8a85cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                OwnershipProof = CapnpSerializable.Create<CapnpGen.OwnershipProof>(reader.OwnershipProof);
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

            public CapnpGen.OwnershipProof OwnershipProof
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public CapnpGen.OwnershipProof.READER OwnershipProof => ctx.ReadStruct(0, CapnpGen.OwnershipProof.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public CapnpGen.OwnershipProof.WRITER OwnershipProof
                {
                    get => BuildPointer<CapnpGen.OwnershipProof.WRITER>(0);
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
                UnsignedTransaction = reader.UnsignedTransaction;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.UnsignedTransaction.Init(UnsignedTransaction);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<byte> UnsignedTransaction
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<byte> UnsignedTransaction => ctx.ReadList(0).CastByte();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ListOfPrimitivesSerializer<byte> UnsignedTransaction
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
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
                Witness = CapnpSerializable.Create<CapnpGen.WitScript>(reader.Witness);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                Witness?.serialize(writer.Witness);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public CapnpGen.WitScript Witness
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public CapnpGen.WitScript.READER Witness => ctx.ReadStruct(0, CapnpGen.WitScript.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public CapnpGen.WitScript.WRITER Witness
                {
                    get => BuildPointer<CapnpGen.WitScript.WRITER>(0);
                    set => Link(0, value);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL), Proxy(typeof(CoinJoinClient_Proxy)), Skeleton(typeof(CoinJoinClient_Skeleton))]
    public interface ICoinJoinClient : IDisposable
    {
        Task<IReadOnlyList<byte>> StartRound(IReadOnlyList<CapnpGen.ISpendableCoin> coins, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL)]
    public class CoinJoinClient_Proxy : Proxy, ICoinJoinClient
    {
        public async Task<IReadOnlyList<byte>> StartRound(IReadOnlyList<CapnpGen.ISpendableCoin> coins, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<CapnpGen.CoinJoinClient.Params_StartRound.WRITER>();
            var arg_ = new CapnpGen.CoinJoinClient.Params_StartRound()
            {Coins = coins};
            arg_?.serialize(in_);
            using (var d_ = await Call(14611412366222466594UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<CapnpGen.CoinJoinClient.Result_StartRound>(d_);
                return (r_.Tx);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcac62a21eb709e22UL)]
    public class CoinJoinClient_Skeleton : Skeleton<ICoinJoinClient>
    {
        public CoinJoinClient_Skeleton()
        {
            SetMethodTable(StartRound);
        }

        public override ulong InterfaceId => 14611412366222466594UL;
        Task<AnswerOrCounterquestion> StartRound(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<CapnpGen.CoinJoinClient.Params_StartRound>(d_);
                return Impatient.MaybeTailCall(Impl.StartRound(in_.Coins, cancellationToken_), tx =>
                {
                    var s_ = SerializerState.CreateForRpc<CapnpGen.CoinJoinClient.Result_StartRound.WRITER>();
                    var r_ = new CapnpGen.CoinJoinClient.Result_StartRound{Tx = tx};
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
        public class Params_StartRound : ICapnpSerializable
        {
            public const UInt64 typeId = 0xe0a6e0b579bbb5a9UL;
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

            public IReadOnlyList<CapnpGen.ISpendableCoin> Coins
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<CapnpGen.ISpendableCoin> Coins => ctx.ReadCapList<CapnpGen.ISpendableCoin>(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ListOfCapsSerializer<CapnpGen.ISpendableCoin> Coins
                {
                    get => BuildPointer<ListOfCapsSerializer<CapnpGen.ISpendableCoin>>(0);
                    set => Link(0, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd1b8bef17476544aUL)]
        public class Result_StartRound : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd1b8bef17476544aUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Tx = reader.Tx;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Tx.Init(Tx);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<byte> Tx
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<byte> Tx => ctx.ReadList(0).CastByte();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ListOfPrimitivesSerializer<byte> Tx
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                    set => Link(0, value);
                }
            }
        }
    }
}