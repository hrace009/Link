using System;

namespace Link.Pools
{
    public interface IPool<T>
    {
        T Take();
        bool Return(T item);
        T Create();
        void Reset(T item);
        void Cleanup(T item);
        void Allocate();
        void Clear();
    }
}

