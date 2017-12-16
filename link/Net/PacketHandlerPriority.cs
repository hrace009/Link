using System;

namespace Link.Net
{
    public enum PacketHandlerPriority 
    {
        Low = 0,
        Normal = 1,
        High = 2,
        System = 8,
        Critical = 10
    }
}

