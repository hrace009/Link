using System;

namespace Link.Pools
{
    public class PoolInstance<P, PV> : IPool<PV> where P : IPool<PV>
    {
        private object lckObject = new object();
        private P instance;

        public P Instance
        {
            get
            {
                lock (lckObject)
                {
                    return instance;
                }
            }
            set
            {
                lock (lckObject)
                {
                    instance = value;
                }
            }
        }

        public P Get()
        {
            return Instance;
        }
        public void Set(P pool)
        {
            Instance = pool;
        }

        public PoolInstance(P defaultInstance)
        {
            Instance = defaultInstance;
        }

        public void SetupNew(P instance)
        {
            lock (lckObject)
            {
                var current = Instance;
                if (current != null)
                {
                    current.Clear();
                }
                Instance = instance;
            }
        }


        public PV Take()
        {
            return instance.Take();
        }
        public bool Return(PV item)
        {
            return instance.Return(item);
        }
        public PV Create()
        {
            return instance.Create();
        }
        public void Reset(PV item)
        {
            instance.Reset(item);
        }
        public void Cleanup(PV item)
        {
            instance.Cleanup(item);
        }
        public void Allocate()
        {
            instance.Allocate();
        }
        public void Clear()
        {
            instance.Clear();
        }
    }
}

