using System;
using System.Collections.Generic;

using Link.IO;
using Link.Net;
using Link.Net.Protocol;

namespace Link.Modules
{
    public abstract class ProtoModuleBase : ModuleBase
    {
        private Dictionary<uint, PacketHandlerPriority> Priorities = new Dictionary<uint, PacketHandlerPriority>();
        private Dictionary<uint, PacketEventHandler> Handlers = new Dictionary<uint, PacketEventHandler>();
        private bool InitTableComplete = false;
        private bool Registered = false;
        
        protected bool Register<TPacket>(PacketEventHandler handler, PacketHandlerPriority priority = PacketHandlerPriority.Normal) where TPacket : IDataSerializer
        {
            var info = Session.Proto.GetInfo<TPacket>();
            if (info == null)
            {
                return false;
            }
            Register(info.Id, handler, priority);
            return true;
        }
        protected void Register(uint packetId, PacketEventHandler handler, PacketHandlerPriority priority = PacketHandlerPriority.Normal)
        {
            Handlers[packetId] = handler;
            Priorities[packetId] = priority;
        }

        public abstract void RegisterHandlers();
        public virtual void InitializeHandlers()
        {
            lock (Handlers)
            {
                if (Registered)
                {
                    return;
                }
                if (!InitTableComplete)
                {
                    RegisterHandlers();
                    InitTableComplete = true;
                }
                foreach (var priority in Priorities)
                {
                    Session.Handler.Get(priority.Key).Add(PreHandler, priority.Value);
                }
                Registered = true;
            }
        }
        public void DestroyHandlers()
        {
            lock (Handlers)
            {
                if (!Registered)
                {
                    return;
                }
                foreach (var priority in Priorities)
                {
                    Session.Handler.Get(priority.Key).Remove(PreHandler);
                }
                Priorities.Clear();
                Handlers.Clear();
                InitTableComplete = false;
                Registered = false;
            }
        }

        public override void Initialize()
        {
            InitializeHandlers();
        }
        public override void Destroy()
        {
            DestroyHandlers();
        }

        private void PreHandler(object sender, PacketEventArgs e)
        {
            if (!Enabled)
            {
                return;
            }
            PacketEventHandler handler;
            if (Handlers.TryGetValue(e.Packet.Id, out handler))
            {
                handler(sender, e);
            }
        }
    }
    public abstract class ModuleBase
    {
        public virtual Session Session { get; set; }
        public virtual ProtoTable Proto { get; set; }
        public virtual bool Enabled { get; set; }

        public abstract void Initialize();
        public abstract void Destroy();
    }
}

