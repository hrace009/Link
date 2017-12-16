using System;
using System.Reflection;
using System.Collections.Generic;

namespace Link.IO
{
    public delegate bool ReadHandler<TE>(DataStream ds, out TE value);
    public delegate void WriteHandler<TE>(DataStream ds, TE value);
    public static class DataStreamIO<TE>
    {
        public static readonly ReadHandler<TE> Reader;
        public static readonly WriteHandler<TE> Writer;


        public static bool TryRead(DataStream ds, out TE value)
        {
            return Reader.Invoke(ds, out value);
        }
        public static void Write(DataStream ds, TE value)
        {
            Writer.Invoke(ds, value);
        }
        private static Dictionary<Type, Tuple<Delegate, Delegate>> RWTable = new Dictionary<Type, Tuple<Delegate, Delegate>>
        {
            {
                typeof(bool), Tuple.Create(
                    (Delegate)new ReadHandler<bool>(delegate(DataStream ds, out bool value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<bool>(delegate(DataStream ds, bool value) { ds.Write(value); }))
            },
            {
                typeof(byte), Tuple.Create(
                    (Delegate)new ReadHandler<byte>(delegate(DataStream ds, out byte value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<byte>(delegate(DataStream ds, byte value) { ds.Write(value); }))
            },
            {
                typeof(sbyte), Tuple.Create(
                    (Delegate)new ReadHandler<sbyte>(delegate(DataStream ds, out sbyte value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<sbyte>(delegate(DataStream ds, sbyte value) { ds.Write(value); }))
            },
            { 
                typeof(short), Tuple.Create(
                    (Delegate)new ReadHandler<short>(delegate(DataStream ds, out short value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<short>(delegate(DataStream ds, short value) { ds.Write(value); }))
            },
            { 
                typeof(int), Tuple.Create(
                    (Delegate)new ReadHandler<int>(delegate(DataStream ds, out int value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<int>(delegate(DataStream ds, int value) { ds.Write(value); }))
            },
            { 
                typeof(long), Tuple.Create(
                    (Delegate)new ReadHandler<long>(delegate(DataStream ds, out long value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<long>(delegate(DataStream ds, long value) { ds.Write(value); }))
            },
            { 
                typeof(ushort), Tuple.Create(
                    (Delegate)new ReadHandler<ushort>(delegate(DataStream ds, out ushort value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<ushort>(delegate(DataStream ds, ushort value) { ds.Write(value); }))
            },
            { 
                typeof(uint), Tuple.Create(
                    (Delegate)new ReadHandler<uint>(delegate(DataStream ds, out uint value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<uint>(delegate(DataStream ds, uint value) { ds.Write(value); }))
            },
            { 
                typeof(ulong), Tuple.Create(
                    (Delegate)new ReadHandler<ulong>(delegate(DataStream ds, out ulong value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<ulong>(delegate(DataStream ds, ulong value) { ds.Write(value); }))
            },
            { 
                typeof(float), Tuple.Create(
                    (Delegate)new ReadHandler<float>(delegate(DataStream ds, out float value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<float>(delegate(DataStream ds, float value) { ds.Write(value); }))
            },
            { 
                typeof(double), Tuple.Create(
                    (Delegate)new ReadHandler<double>(delegate(DataStream ds, out double value) { return ds.TryRead(out value); }),
                    (Delegate)new WriteHandler<double>(delegate(DataStream ds, double value) { ds.Write(value); }))
            }
        };

        static DataStreamIO()
        {
            if (Reader != null && Writer != null)
            {
                return;
            }
            Tuple<Delegate, Delegate> pair;
            if (RWTable.TryGetValue(typeof(TE), out pair))
            {
                Reader = (ReadHandler<TE>)pair.Item1;
                Writer = (WriteHandler<TE>)pair.Item2;
            }
            else
            {
                if (typeof(IDataSerializer).IsAssignableFrom(typeof(TE)))
                {
                    Reader = new ReadHandler<TE>((delegate(DataStream ds, out TE value)
                        {
                            value = Helpers.FastConstructor<TE>.Create();
                            var dataSerializer = (IDataSerializer)value;
                            return ds.TryRead(dataSerializer);
                        }));
                    Writer = new WriteHandler<TE>((delegate(DataStream ds, TE value) 
                        {
                            var dataSerializer = (IDataSerializer)value;
                            ds.Write(dataSerializer);
                        }));
                }
                else
                {
                    throw new Exception("Unknown type");
                }
            }

        }
    }

}

