using System;

namespace Link.Net
{
    public enum PacketReaderState
    {
        WaitingId = 0,
        WaitingLength = 1,
        WaitingContent = 2, 
        Complete = 3
    }
}

