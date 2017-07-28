using System;
using System.Collections.Generic;

namespace Link.Net
{
    public class RouteOutputHandler : Route
    {
        public PacketHandler<bool> OutputHandler;

        public RouteOutputHandler()
        {
            
        }
        public RouteOutputHandler(PacketHandler<bool> outputHandler)
        {
            OutputHandler = outputHandler;
        }

        public override bool Send(Packet packet)
        {
            return OutputHandler?.Invoke(this, packet) ?? false;
        }
        public void Clear()
        {
            OutputHandler = null;
        }
    }
}

