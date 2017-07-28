using System;

namespace Link.Net
{
    public class RouteChain : Route
    {
        private Route nextChain;
        public Route Next
        {
            get
            {
                return nextChain;
            }
            set
            {
                nextChain = value;
            }
        }

        public static void Combine(RouteChain inputRoute, Route outputRoute)
        {
            inputRoute.Next = outputRoute;
        }

        public RouteChain() : this(null)
        {
            
        }
        public RouteChain(Route outputRoute)
        {
            Next = outputRoute;
        }

        public override bool Send(Packet packet)
        {
            return nextChain?.Send(packet) ?? false;
        }
        public void Clear()
        {
            Next = null;
        }
    }
}

