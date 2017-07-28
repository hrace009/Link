using System;
using System.Collections;
using System.Collections.Generic;

namespace Link.IO
{
    public class Vector<TBase, TRead> : Vector<TBase> where TRead : TBase
    {
        public Vector()
        {

        }
        public Vector(TBase[] data) : base(data)
        {
        }
        public Vector(TRead[] data)
        {
            if (data == null || data.Length == 0)
            {
                return;
            }
            Data = new TBase[data.Length];
            for (var i = 0; i < data.Length; i++)
            {
                Data[i] = data[i];
            }
        }
        public override bool TryDeserialize(DataStream ds)
        {
            uint count;
            if (!ds.TryReadCompactUInt32(out count))
            {
                return false;
            }
            var result = new TBase[(int)count];
            for (var i = 0; i < result.Length; i++)
            {
                TRead r;
                if (!ds.TryRead(out r))
                {
                    return false;
                }
                result[i] = r;
            }
            Data = result;
            return true;
        }
    }
    public class Vector<T> : IDataSerializer, IEnumerable<T>
    {
        private static readonly T[] empty = { };

        private T[] data;
        public T[] Data
        {
            get
            {
                return data ?? empty;
            }
            set
            {
                data = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return Data?.Length ?? 0;
            }
        }

        public Vector()
        {
        }
        public Vector(T[] data)
        {
            Data = data;
        }
        public static explicit operator T[](Vector<T> vector)
        {
            return vector.Data;
        }
        public static implicit operator Vector<T>(T[] data)
        {
            return new Vector<T>(data);
        }

        public virtual DataStream Serialize(DataStream ds)
        {
            ds.WriteCompactUInt32(Count);
            foreach (var item in this)
            {
                ds.Write(item);
            }
            return ds;
        }
        public virtual bool TryDeserialize(DataStream ds)
        {
            uint count;
            if (!ds.TryReadCompactUInt32(out count))
            {
                return false;
            }
            var result = new T[(int)count];
            for (var i = 0; i < result.Length; i++)
            {
                if (!ds.TryRead(out result[i]))
                {
                    return false;
                }
            }
            Data = result;
            return true;
        }
    }
}

