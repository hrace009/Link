using System;
using System.Collections.Generic;
using System.Threading;

using Link.Net;
using Link.Net.Protocol.Core;

namespace Link.Modules
{
    public class RolesLoaderModule : ProtoModuleBase
    {
        public int UserId;
        public ManualResetEventSlim LoadedWaiter { get; private set; }
        public bool AutoLoad { get; set; }
        public bool Loaded
        {
            get
            {
                return LoadedWaiter.IsSet;
            }
            private set
            {
                if (value == LoadedWaiter.IsSet)
                {
                    return;
                }
                if (value)
                {
                    LoadedWaiter.Set();
                }
                else
                {
                    LoadedWaiter.Reset();
                }

                LoadedChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler LoadedChanged;

        public List<RoleInfo> Roles { get; private set; }

        public RolesLoaderModule()
        {
            LoadedWaiter = new ManualResetEventSlim(false);
            Roles = new List<RoleInfo>();
            AutoLoad = true;
        }

        public override void Destroy()
        {
            Roles.Clear();
            base.Destroy();
        }
        public override void RegisterHandlers()
        {
            Register<OnlineAnnounce>(OnlineAnnounceReceive);
            Register<RoleList_Re>(RoleListReReceive);
        }
        public override void Initialize()
        {
            base.Initialize();

            Session.StateChanged += Session_StateChanged;
        }

        private void Session_StateChanged(object sender, EventArgs e)
        {
            Loaded = false;
        }

        private void OnlineAnnounceReceive(object sender, PacketEventArgs e)
        {
            if (!e.IsComplete)
            {
                Loaded = false;
                var onlineAnnounce = e.Packet.ReadPacket<OnlineAnnounce>();
                UserId = onlineAnnounce.UserID.Value;
                if (e.Chain.IsInput && AutoLoad)
                {
                    LoadNext(-1);
                }
            }
        }
        private void RoleListReReceive(object sender, PacketEventArgs e)
        {
            if (!e.IsComplete)
            {
                var roleList = e.Packet.ReadPacket<RoleList_Re>();
                foreach (var role in roleList.RoleList)
                {
                    Roles.Add(role);
                }
                if (roleList.Handle == -1)
                {
                    Loaded = true;
                }
                else
                {
                    if (e.Chain.IsInput && AutoLoad)
                    {
                        LoadNext(roleList.Handle.Value);
                    }
                }
            }
        }
        private void LoadNext(int handle)
        {
            var roleList = Proto.Get<RoleList>();
            roleList.UserID = UserId;
            roleList.Handle = handle;
            Session.Send(roleList);
        }
    }
}

