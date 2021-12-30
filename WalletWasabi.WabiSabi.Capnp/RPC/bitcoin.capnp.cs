using Capnp;
using Capnp.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin
{
    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xec5ffd5cdd3da528UL)]
    public class Money : ICapnpSerializable
    {
        public const UInt64 typeId = 0xec5ffd5cdd3da528UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Satoshis = reader.Satoshis;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Satoshis = Satoshis;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong Satoshis
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
            public ulong Satoshis => ctx.ReadDataULong(0UL, 0UL);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public ulong Satoshis
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfc994367cbf38456UL)]
    public class Script : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfc994367cbf38456UL;
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

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc2e1e5df8d8ecd7cUL)]
    public class WitScript : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc2e1e5df8d8ecd7cUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Pushes = reader.Pushes;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Pushes.Init(Pushes, (_s1, _v1) => _s1.Init(_v1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<IReadOnlyList<byte>> Pushes
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
            public IReadOnlyList<IReadOnlyList<byte>> Pushes => ctx.ReadList(0).CastData();
            public bool HasPushes => ctx.IsStructFieldNonNull(0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 1);
            }

            public ListOfPointersSerializer<ListOfPrimitivesSerializer<byte>> Pushes
            {
                get => BuildPointer<ListOfPointersSerializer<ListOfPrimitivesSerializer<byte>>>(0);
                set => Link(0, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb2517c7e97f6fea3UL)]
    public class TxOut : ICapnpSerializable
    {
        public const UInt64 typeId = 0xb2517c7e97f6fea3UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            ScriptPubKey = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script>(reader.ScriptPubKey);
            Value = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money>(reader.Value);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            ScriptPubKey?.serialize(writer.ScriptPubKey);
            Value?.serialize(writer.Value);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script ScriptPubKey
        {
            get;
            set;
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money Value
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
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER ScriptPubKey => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.READER.create);
            public bool HasScriptPubKey => ctx.IsStructFieldNonNull(0);
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money.READER Value => ctx.ReadStruct(1, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money.READER.create);
            public bool HasValue => ctx.IsStructFieldNonNull(1);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.WRITER ScriptPubKey
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Script.WRITER>(0);
                set => Link(0, value);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money.WRITER Value
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.Money.WRITER>(1);
                set => Link(1, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe5e671075fd231acUL)]
    public class UInt256 : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe5e671075fd231acUL;
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

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xecec28030f8aa73fUL)]
    public class OutPoint : ICapnpSerializable
    {
        public const UInt64 typeId = 0xecec28030f8aa73fUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Txid = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256>(reader.Txid);
            Nout = reader.Nout;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Txid?.serialize(writer.Txid);
            writer.Nout = Nout;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256 Txid
        {
            get;
            set;
        }

        public uint Nout
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
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256.READER Txid => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256.READER.create);
            public bool HasTxid => ctx.IsStructFieldNonNull(0);
            public uint Nout => ctx.ReadDataUInt(0UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256.WRITER Txid
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.UInt256.WRITER>(0);
                set => Link(0, value);
            }

            public uint Nout
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc83865acf8d6ebc8UL)]
    public class Coin : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc83865acf8d6ebc8UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Outpoint = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint>(reader.Outpoint);
            TxOut = CapnpSerializable.Create<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut>(reader.TxOut);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Outpoint?.serialize(writer.Outpoint);
            TxOut?.serialize(writer.TxOut);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint Outpoint
        {
            get;
            set;
        }

        public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut TxOut
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
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint.READER Outpoint => ctx.ReadStruct(0, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint.READER.create);
            public bool HasOutpoint => ctx.IsStructFieldNonNull(0);
            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut.READER TxOut => ctx.ReadStruct(1, WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut.READER.create);
            public bool HasTxOut => ctx.IsStructFieldNonNull(1);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint.WRITER Outpoint
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.OutPoint.WRITER>(0);
                set => Link(0, value);
            }

            public WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut.WRITER TxOut
            {
                get => BuildPointer<WalletWasabi.WabiSabi.Capnp.RPC.Bitcoin.TxOut.WRITER>(1);
                set => Link(1, value);
            }
        }
    }
}