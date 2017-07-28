using System;
using System.Collections.Generic;

namespace Link.Net
{
    public class PacketHandlerList
    {
        private object lckObj = new object();

        private SortedSet<PacketHandlerPriorityContainer> handlersSet = new SortedSet<PacketHandlerPriorityContainer>();
        private Dictionary<PacketEventHandler, PacketHandlerPriorityContainer> containersTable = new Dictionary<PacketEventHandler, PacketHandlerPriorityContainer>();

        public IEnumerable<PacketEventHandler> Handlers
        {
            get
            {
                lock (lckObj)
                {
                    
                    foreach (var x in handlersSet.Reverse())
                    {
                        yield return x.Handler;
                    }
                }
            }
        }

        public void Add(PacketEventHandler handler, PacketHandlerPriority priority = PacketHandlerPriority.Normal)
        {
            lock (lckObj)
            {
                Remove(handler);
                var container = new PacketHandlerPriorityContainer(handler, priority);
                containersTable[handler] = container;
                handlersSet.Add(container);
            }
        }
        public void Remove(PacketEventHandler handler)
        {
            lock (lckObj)
            {
                PacketHandlerPriorityContainer container;
                if (containersTable.TryGetValue(handler, out container))
                {
                    handlersSet.Remove(container);
                }
                containersTable.Remove(handler);
            }
        }
        public void Clear()
        {
            lock (lckObj)
            {
                handlersSet.Clear();
                containersTable.Clear();
            }
        }
    }
}

