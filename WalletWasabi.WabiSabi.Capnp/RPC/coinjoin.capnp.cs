using Capnp;
using Capnp.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf1b7308c2ba6dc91UL), Proxy(typeof(SpendCapability_Proxy)), Skeleton(typeof(SpendCapability_Skeleton))]
    public interface ISpendCapability : IDisposable
    {
        Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof> ProveOwnership(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default);
        Task<(uint, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript)> Sign(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf1b7308c2ba6dc91UL)]
    public class SpendCapability_Proxy : Proxy, ISpendCapability
    {
        public async Task<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof> ProveOwnership(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData commitmentData, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_ProveOwnership.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_ProveOwnership()
            {CommitmentData = commitmentData};
            arg_?.serialize(in_);
            using (var d_ = await Call(17417443462464593041UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_ProveOwnership>(d_);
                return (r_.OwnershipProof);
            }
        }

        public async Task<(uint, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript)> Sign(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction unsignedTransaction, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_Sign.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_Sign()
            {UnsignedTransaction = unsignedTransaction};
            arg_?.serialize(in_);
            using (var d_ = await Call(17417443462464593041UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_Sign>(d_);
                return (r_.Index, r_.Witness);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf1b7308c2ba6dc91UL)]
    public class SpendCapability_Skeleton : Skeleton<ISpendCapability>
    {
        public SpendCapability_Skeleton()
        {
            SetMethodTable(ProveOwnership, Sign);
        }

        public override ulong InterfaceId => 17417443462464593041UL;
        Task<AnswerOrCounterquestion> ProveOwnership(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_ProveOwnership>(d_);
                return Impatient.MaybeTailCall(Impl.ProveOwnership(in_.CommitmentData, cancellationToken_), ownershipProof =>
                {
                    var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_ProveOwnership.WRITER>();
                    var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_ProveOwnership{OwnershipProof = ownershipProof};
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
                var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Params_Sign>(d_);
                return Impatient.MaybeTailCall(Impl.Sign(in_.UnsignedTransaction, cancellationToken_), (index, witness) =>
                {
                    var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_Sign.WRITER>();
                    var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendCapability.Result_Sign{Index = index, Witness = witness};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }
    }

    public static class SpendCapability
    {
        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbf5238ce48e84a6dUL)]
        public class Params_ProveOwnership : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbf5238ce48e84a6dUL;
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
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.READER CommitmentData => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CommitmentData.READER.create);
                public bool HasCommitmentData => ctx.IsStructFieldNonNull(0);
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf42b097d1392602bUL)]
        public class Result_ProveOwnership : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf42b097d1392602bUL;
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
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.READER OwnershipProof => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.OwnershipProof.READER.create);
                public bool HasOwnershipProof => ctx.IsStructFieldNonNull(0);
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x94d27f5cd6e0ade8UL)]
        public class Params_Sign : ICapnpSerializable
        {
            public const UInt64 typeId = 0x94d27f5cd6e0ade8UL;
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
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.READER UnsignedTransaction => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.RawTransaction.READER.create);
                public bool HasUnsignedTransaction => ctx.IsStructFieldNonNull(0);
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc6bbbb300eec3a64UL)]
        public class Result_Sign : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc6bbbb300eec3a64UL;
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
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public uint Index => ctx.ReadDataUInt(0UL, 0U);
                public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.READER Witness => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.WitScript.READER.create);
                public bool HasWitness => ctx.IsStructFieldNonNull(0);
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
            readonly DeserializerState ctx;
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

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9aa0e48be69971c5UL), Proxy(typeof(CoinJoinEvents_Proxy)), Skeleton(typeof(CoinJoinEvents_Skeleton))]
    public interface ICoinJoinEvents : IDisposable
    {
        Task CoinJoinStarted(CancellationToken cancellationToken_ = default);
        Task CoinJoinNoLongerInProgress(CancellationToken cancellationToken_ = default);
        Task ReportedSpentAccordingToBackend(CancellationToken cancellationToken_ = default);
        Task Banned(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset until, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9aa0e48be69971c5UL)]
    public class CoinJoinEvents_Proxy : Proxy, ICoinJoinEvents
    {
        public async Task CoinJoinStarted(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_CoinJoinStarted.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_CoinJoinStarted()
            {};
            arg_?.serialize(in_);
            using (var d_ = await Call(11142156767635009989UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_CoinJoinStarted>(d_);
                return;
            }
        }

        public async Task CoinJoinNoLongerInProgress(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_CoinJoinNoLongerInProgress.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_CoinJoinNoLongerInProgress()
            {};
            arg_?.serialize(in_);
            using (var d_ = await Call(11142156767635009989UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_CoinJoinNoLongerInProgress>(d_);
                return;
            }
        }

        public async Task ReportedSpentAccordingToBackend(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_ReportedSpentAccordingToBackend.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_ReportedSpentAccordingToBackend()
            {};
            arg_?.serialize(in_);
            using (var d_ = await Call(11142156767635009989UL, 2, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_ReportedSpentAccordingToBackend>(d_);
                return;
            }
        }

        public async Task Banned(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset until, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_Banned.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_Banned()
            {Until = until};
            arg_?.serialize(in_);
            using (var d_ = await Call(11142156767635009989UL, 3, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_Banned>(d_);
                return;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9aa0e48be69971c5UL)]
    public class CoinJoinEvents_Skeleton : Skeleton<ICoinJoinEvents>
    {
        public CoinJoinEvents_Skeleton()
        {
            SetMethodTable(CoinJoinStarted, CoinJoinNoLongerInProgress, ReportedSpentAccordingToBackend, Banned);
        }

        public override ulong InterfaceId => 11142156767635009989UL;
        async Task<AnswerOrCounterquestion> CoinJoinStarted(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                await Impl.CoinJoinStarted(cancellationToken_);
                var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_CoinJoinStarted.WRITER>();
                return s_;
            }
        }

        async Task<AnswerOrCounterquestion> CoinJoinNoLongerInProgress(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                await Impl.CoinJoinNoLongerInProgress(cancellationToken_);
                var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_CoinJoinNoLongerInProgress.WRITER>();
                return s_;
            }
        }

        async Task<AnswerOrCounterquestion> ReportedSpentAccordingToBackend(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                await Impl.ReportedSpentAccordingToBackend(cancellationToken_);
                var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_ReportedSpentAccordingToBackend.WRITER>();
                return s_;
            }
        }

        async Task<AnswerOrCounterquestion> Banned(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Params_Banned>(d_);
                await Impl.Banned(in_.Until, cancellationToken_);
                var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoinEvents.Result_Banned.WRITER>();
                return s_;
            }
        }
    }

    public static class CoinJoinEvents
    {
        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd8ae6c94bea03b80UL)]
        public class Params_CoinJoinStarted : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd8ae6c94bea03b80UL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc189afd75113204bUL)]
        public class Result_CoinJoinStarted : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc189afd75113204bUL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb8e9b85866f36b8fUL)]
        public class Params_CoinJoinNoLongerInProgress : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb8e9b85866f36b8fUL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe93d1c07f4d256cUL)]
        public class Result_CoinJoinNoLongerInProgress : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfe93d1c07f4d256cUL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb7de15b2ab53075aUL)]
        public class Params_ReportedSpentAccordingToBackend : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb7de15b2ab53075aUL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8f31e8fff8a74204UL)]
        public class Result_ReportedSpentAccordingToBackend : ICapnpSerializable
        {
            public const UInt64 typeId = 0x8f31e8fff8a74204UL;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb1403ebe0df7b6fcUL)]
        public class Params_Banned : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb1403ebe0df7b6fcUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Until = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset>(reader.Until);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                Until?.serialize(writer.Until);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset Until
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
                public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset.READER Until => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset.READER.create);
                public bool HasUntil => ctx.IsStructFieldNonNull(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset.WRITER Until
                {
                    get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.DateTimeOffset.WRITER>(0);
                    set => Link(0, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x90a5fa0b31c97ebaUL)]
        public class Result_Banned : ICapnpSerializable
        {
            public const UInt64 typeId = 0x90a5fa0b31c97ebaUL;
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
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdec4b1061fa0478dUL)]
    public class CoinStatus : ICapnpSerializable
    {
        public const UInt64 typeId = 0xdec4b1061fa0478dUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            IsConfirmed = reader.IsConfirmed;
            IsBanned = reader.IsBanned;
            AnonymitySetSizeEstimate = reader.AnonymitySetSizeEstimate;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.IsConfirmed = IsConfirmed;
            writer.IsBanned = IsBanned;
            writer.AnonymitySetSizeEstimate = AnonymitySetSizeEstimate;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public bool IsConfirmed
        {
            get;
            set;
        }

        public bool IsBanned
        {
            get;
            set;
        }

        public int AnonymitySetSizeEstimate
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
            public bool IsConfirmed => ctx.ReadDataBool(0UL, false);
            public bool IsBanned => ctx.ReadDataBool(1UL, false);
            public int AnonymitySetSizeEstimate => ctx.ReadDataInt(32UL, 0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public bool IsConfirmed
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public bool IsBanned
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }

            public int AnonymitySetSizeEstimate
            {
                get => this.ReadDataInt(32UL, 0);
                set => this.WriteData(32UL, value, 0);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd12425dac9a33ac2UL)]
    public class SpendableCoin : ICapnpSerializable
    {
        public const UInt64 typeId = 0xd12425dac9a33ac2UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Coin = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin>(reader.Coin);
            SpendCapability = reader.SpendCapability;
            Status = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus>(reader.Status);
            Events = reader.Events;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Coin?.serialize(writer.Coin);
            writer.SpendCapability = SpendCapability;
            Status?.serialize(writer.Status);
            writer.Events = Events;
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

        public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendCapability SpendCapability
        {
            get;
            set;
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus Status
        {
            get;
            set;
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ICoinJoinEvents Events
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
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.READER Coin => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.READER.create);
            public bool HasCoin => ctx.IsStructFieldNonNull(0);
            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendCapability SpendCapability => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendCapability>(1);
            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus.READER Status => ctx.ReadStruct(2, WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus.READER.create);
            public bool HasStatus => ctx.IsStructFieldNonNull(2);
            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ICoinJoinEvents Events => ctx.ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ICoinJoinEvents>(3);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 4);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.WRITER Coin
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Coin.WRITER>(0);
                set => Link(0, value);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendCapability SpendCapability
            {
                get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ISpendCapability>(1);
                set => LinkObject(1, value);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus.WRITER Status
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinStatus.WRITER>(2);
                set => Link(2, value);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ICoinJoinEvents Events
            {
                get => ReadCap<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.ICoinJoinEvents>(3);
                set => LinkObject(3, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee0c45dd09eb9d61UL), Proxy(typeof(Wallet_Proxy)), Skeleton(typeof(Wallet_Skeleton))]
    public interface IWallet : IDisposable
    {
        Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin>> GetAvailableCoins(CancellationToken cancellationToken_ = default);
        Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>> GenerateSelfSpendScripts(int count, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xee0c45dd09eb9d61UL)]
    public class Wallet_Proxy : Proxy, IWallet
    {
        public Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin>> GetAvailableCoins(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GetAvailableCoins.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GetAvailableCoins()
            {};
            arg_?.serialize(in_);
            return Impatient.MakePipelineAware(Call(17153161896403901793UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                using (d_)
                {
                    var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GetAvailableCoins>(d_);
                    return (r_.Coins);
                }
            }

            );
        }

        public async Task<IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>> GenerateSelfSpendScripts(int count, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts()
            {Count = count};
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
            SetMethodTable(GetAvailableCoins, GenerateSelfSpendScripts);
        }

        public override ulong InterfaceId => 17153161896403901793UL;
        Task<AnswerOrCounterquestion> GetAvailableCoins(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                return Impatient.MaybeTailCall(Impl.GetAvailableCoins(cancellationToken_), coins =>
                {
                    var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GetAvailableCoins.WRITER>();
                    var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GetAvailableCoins{Coins = coins};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }

        Task<AnswerOrCounterquestion> GenerateSelfSpendScripts(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Params_GenerateSelfSpendScripts>(d_);
                return Impatient.MaybeTailCall(Impl.GenerateSelfSpendScripts(in_.Count, cancellationToken_), scriptPubKeys =>
                {
                    var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GenerateSelfSpendScripts.WRITER>();
                    var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.Wallet.Result_GenerateSelfSpendScripts{ScriptPubKeys = scriptPubKeys};
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
        public class Params_GetAvailableCoins : ICapnpSerializable
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe384f3d2a9715a65UL)]
        public class Result_GetAvailableCoins : ICapnpSerializable
        {
            public const UInt64 typeId = 0xe384f3d2a9715a65UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Coins = reader.Coins?.ToReadOnlyList(_ => CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin>(_));
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Coins.Init(Coins, (_s1, _v1) => _v1?.serialize(_s1));
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin> Coins
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
                public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.READER> Coins => ctx.ReadList(0).Cast(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.READER.create);
                public bool HasCoins => ctx.IsStructFieldNonNull(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ListOfStructsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.WRITER> Coins
                {
                    get => BuildPointer<ListOfStructsSerializer<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.SpendableCoin.WRITER>>(0);
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
                readonly DeserializerState ctx;
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
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER> ScriptPubKeys => ctx.ReadList(0).Cast(WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER.create);
                public bool HasScriptPubKeys => ctx.IsStructFieldNonNull(0);
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

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe506fb309b96917UL), Proxy(typeof(CoinJoiner_Proxy)), Skeleton(typeof(CoinJoiner_Skeleton))]
    public interface ICoinJoiner : IDisposable
    {
        Task<bool> StartCoinJoin(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default);
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe506fb309b96917UL)]
    public class CoinJoiner_Proxy : Proxy, ICoinJoiner
    {
        public async Task<bool> StartCoinJoin(WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.IWallet wallet, CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Params_StartCoinJoin.WRITER>();
            var arg_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Params_StartCoinJoin()
            {Wallet = wallet};
            arg_?.serialize(in_);
            using (var d_ = await Call(18325269698523523351UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned)
            {
                var r_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Result_StartCoinJoin>(d_);
                return (r_.Succeeded);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe506fb309b96917UL)]
    public class CoinJoiner_Skeleton : Skeleton<ICoinJoiner>
    {
        public CoinJoiner_Skeleton()
        {
            SetMethodTable(StartCoinJoin);
        }

        public override ulong InterfaceId => 18325269698523523351UL;
        Task<AnswerOrCounterquestion> StartCoinJoin(DeserializerState d_, CancellationToken cancellationToken_)
        {
            using (d_)
            {
                var in_ = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Params_StartCoinJoin>(d_);
                return Impatient.MaybeTailCall(Impl.StartCoinJoin(in_.Wallet, cancellationToken_), succeeded =>
                {
                    var s_ = SerializerState.CreateForRpc<WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Result_StartCoinJoin.WRITER>();
                    var r_ = new WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin.CoinJoiner.Result_StartCoinJoin{Succeeded = succeeded};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }
    }

    public static class CoinJoiner
    {
        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdc48b368eeef5918UL)]
        public class Params_StartCoinJoin : ICapnpSerializable
        {
            public const UInt64 typeId = 0xdc48b368eeef5918UL;
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
                readonly DeserializerState ctx;
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

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x850422431e83aff1UL)]
        public class Result_StartCoinJoin : ICapnpSerializable
        {
            public const UInt64 typeId = 0x850422431e83aff1UL;
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
                readonly DeserializerState ctx;
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
    }
}