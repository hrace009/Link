using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.IO
{
    public class FieldContainer<T> : IDataSerializer
    {
        public T Value { get; private set; }
        public bool IsEmpty { get; private set; }

        public FieldContainer()
        {
            IsEmpty = true;
        }
        public FieldContainer(T value)
        {
            IsEmpty = false;
            Value = value;
        }
        public static explicit operator T(FieldContainer<T> value)
        {
            return value.Value;
        }
        public static explicit operator FieldContainer<T>(T value)
        {
            return new FieldContainer<T>(value);
        }

        public DataStream Serialize(DataStream ds)
        {
            DataStreamIO<T>.Write(ds, Value);
            return ds;
        }

        public bool TryDeserialize(DataStream ds)
        {
            T value;
            if (DataStreamIO<T>.TryRead(ds, out value))
            {
                Value = value;
                IsEmpty = false;
                return true;
            }
            else
            {
                IsEmpty = true;
                return false;
            }
        }
    }
}
