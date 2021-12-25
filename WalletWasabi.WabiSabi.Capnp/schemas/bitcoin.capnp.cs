using Capnp;
using Capnp.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CapnpGen
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
            ScriptPubKey = CapnpSerializable.Create<CapnpGen.Script>(reader.ScriptPubKey);
            Value = CapnpSerializable.Create<CapnpGen.Money>(reader.Value);
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

        public CapnpGen.Script ScriptPubKey
        {
            get;
            set;
        }

        public CapnpGen.Money Value
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
            public CapnpGen.Script.READER ScriptPubKey => ctx.ReadStruct(0, CapnpGen.Script.READER.create);
            public CapnpGen.Money.READER Value => ctx.ReadStruct(1, CapnpGen.Money.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public CapnpGen.Script.WRITER ScriptPubKey
            {
                get => BuildPointer<CapnpGen.Script.WRITER>(0);
                set => Link(0, value);
            }

            public CapnpGen.Money.WRITER Value
            {
                get => BuildPointer<CapnpGen.Money.WRITER>(1);
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
            X0 = reader.X0;
            X1 = reader.X1;
            X2 = reader.X2;
            X3 = reader.X3;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.X0 = X0;
            writer.X1 = X1;
            writer.X2 = X2;
            writer.X3 = X3;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong X0
        {
            get;
            set;
        }

        public ulong X1
        {
            get;
            set;
        }

        public ulong X2
        {
            get;
            set;
        }

        public ulong X3
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
            public ulong X0 => ctx.ReadDataULong(0UL, 0UL);
            public ulong X1 => ctx.ReadDataULong(64UL, 0UL);
            public ulong X2 => ctx.ReadDataULong(128UL, 0UL);
            public ulong X3 => ctx.ReadDataULong(192UL, 0UL);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(4, 0);
            }

            public ulong X0
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public ulong X1
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public ulong X2
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public ulong X3
            {
                get => this.ReadDataULong(192UL, 0UL);
                set => this.WriteData(192UL, value, 0UL);
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
            Txid = CapnpSerializable.Create<CapnpGen.UInt256>(reader.Txid);
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

        public CapnpGen.UInt256 Txid
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
            public CapnpGen.UInt256.READER Txid => ctx.ReadStruct(0, CapnpGen.UInt256.READER.create);
            public uint Nout => ctx.ReadDataUInt(0UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public CapnpGen.UInt256.WRITER Txid
            {
                get => BuildPointer<CapnpGen.UInt256.WRITER>(0);
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
            Outpoint = CapnpSerializable.Create<CapnpGen.OutPoint>(reader.Outpoint);
            Txout = CapnpSerializable.Create<CapnpGen.TxOut>(reader.Txout);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Outpoint?.serialize(writer.Outpoint);
            Txout?.serialize(writer.Txout);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public CapnpGen.OutPoint Outpoint
        {
            get;
            set;
        }

        public CapnpGen.TxOut Txout
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
            public CapnpGen.OutPoint.READER Outpoint => ctx.ReadStruct(0, CapnpGen.OutPoint.READER.create);
            public CapnpGen.TxOut.READER Txout => ctx.ReadStruct(1, CapnpGen.TxOut.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public CapnpGen.OutPoint.WRITER Outpoint
            {
                get => BuildPointer<CapnpGen.OutPoint.WRITER>(0);
                set => Link(0, value);
            }

            public CapnpGen.TxOut.WRITER Txout
            {
                get => BuildPointer<CapnpGen.TxOut.WRITER>(1);
                set => Link(1, value);
            }
        }
    }
}