using System;
using System.Collections.Generic;
using System.Text;

using Link.Threading;
using Link.Net;
using Link.Net.Protocol.Core;

namespace Link.Modules
{
    public class KeepAliveModule : ProtoModuleBase
    {
        private readonly ActionTimer Timer;

        public KeepAliveModule()
        {
            Timer = new ActionTimer(Tick);
        }

        public override void Initialize()
        {
            Session.Connection.StateChanged += Connection_StateChanged;
            base.Initialize();
        }

        public override void Destroy()
        {
            Session.Connection.StateChanged -= Connection_StateChanged;
            Timer.Stop();
            base.Destroy();
        }
        public override void RegisterHandlers()
        {
            Register<OnlineAnnounce>(OnOnlineAnnounce);
        }
        private void OnOnlineAnnounce(object sender, PacketEventArgs e)
        {
            Timer.Start(0, 10000);
        }

        private void Connection_StateChanged(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Tick(object obj)
        {
            var keepAlive = Proto.Get<Keepalive>();
            keepAlive.Code = 0x5A;
            Session.Send(keepAlive);
        }
    }
}
