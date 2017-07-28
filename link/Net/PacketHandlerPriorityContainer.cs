using System;
using System.Threading;

namespace Link.Net
{
    public struct PacketHandlerPriorityContainer : IComparable<PacketHandlerPriorityContainer>
    {
        private static long idCounter;

        public long Id { get; private set; }
        public PacketEventHandler Handler { get; private set; }
        public PacketHandlerPriority Priority { get; private set; }

        public PacketHandlerPriorityContainer(PacketEventHandler handler, PacketHandlerPriority priority = PacketHandlerPriority.Normal)
        {
            Id = Interlocked.Increment(ref idCounter);
            Handler = handler;
            Priority = priority;
        }
        public int CompareTo(PacketHandlerPriorityContainer container)
        {
            var result = Priority.CompareTo(container.Priority);
            if (result == 0)
            {
                result = -(Id.CompareTo(container.Id));
            }
            return result;
        }
    }
}

