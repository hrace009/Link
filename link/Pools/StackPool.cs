using System;
using System.Collections.Generic;

namespace Link.Pools
{
    public abstract class StackPool<T> : IPool<T>
    {
        public int AllocateDefaultCount { get; set; }
        public int MaxFreeCount { get; set; }
        public Stack<T> FreeItems { get; private set; }

        public StackPool(int maxFreeCount = 1024, int allocateDefaultCount = 16)
        {
            MaxFreeCount = maxFreeCount;
            AllocateDefaultCount = allocateDefaultCount;
            FreeItems = new Stack<T>();
        }

        public object LockObject
        {
            get
            {
                return FreeItems;
            }
        }
        public int Count
        {
            get
            {
                return FreeItems.Count;
            }
        }

        public virtual T Take()
        {
            lock (LockObject)
            {
                if (FreeItems.Count == 0)
                {
                    if (MaxFreeCount == 0 || AllocateDefaultCount == 0)
                    {
                        return Create();
                    }
                    Allocate();
                }
                return FreeItems.Pop();
            }
        }
        public bool Return(T item)
        {
            return Return(item, false);
        }
        public virtual bool Return(T item, bool force)
        {
            Reset(item);
            lock (LockObject)
            {
                if (FreeItems.Count < MaxFreeCount || force)
                {
                    FreeItems.Push(item);
                    return true;
                }
                else
                {
                    Cleanup(item);
                    return false;
                }
            }
        }
        public abstract T Create();
        public virtual void Clear()
        {
            lock (LockObject)
            {
                while (FreeItems.Count > 0)
                {
                    Cleanup(FreeItems.Pop());
                }
            }
        }
        public virtual void Reset(T item)
        {
        }
        public virtual void Cleanup(T item)
        {
        }
        public void Allocate()
        {
            Allocate(AllocateDefaultCount <= 0 ? 1 : AllocateDefaultCount);
        }
        public virtual void Allocate(int count)
        {
            while (count-- > 0)
            {
                Return(Create());
            }
        }
    }
}

