using System;
using System.Threading;

using Link.IO;
using Link.Pools;
using Link.Net.Protocol;

namespace Link.Net
{
    public class RouteSession : RouteChain
    {
        public Session Session { get; set; }
        public PacketHandlerTable Handler { get; set; }
        public RouteSession Redirect { get; set; }
        public bool IsInput { get; set; }

        public ManualResetEventSlim Locker { get; private set; } = new ManualResetEventSlim(true);

        public override bool Send(uint packetId, IDataSerializer packet)
        {
            var pck = Session.GetPacket(packetId);
            pck.WritePacket(packet);
            var res = Send(pck);
            Session.DataStreamPool.Return(pck.Stream);
            return res;
        }
        public override bool Send(Packet packet)
        {
            Locker.Wait();
            var args = new PacketEventArgs(packet, this);

            Handler.ProcessPacket(args);
            if (!args.IsComplete)
            {
                var error = !(args.IsSended = base.Send(packet));
                args.IsComplete = true;
                Handler.ProcessPacket(args);
                if (error)
                {
                    return false;
                }
            }
            return true;
        }
        public virtual bool SendPacket<T>(T data) where T : IDataSerializer
        {
            var info = Session.Proto.GetInfo<T>();
            if (info == null)
            {
                return false;
            }
            return Send(info.Id, data);
        }
        public new void Clear()
        {
            base.Clear();
            Session = null;
            Handler = null;
            Redirect = null;
            IsInput = false;
        }
    }
}

