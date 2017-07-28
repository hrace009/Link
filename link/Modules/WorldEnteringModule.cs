using System;
using System.Threading;

using Link.Net;
using Link.IO;
using Link.Net.Protocol.Core;

using System.Threading.Tasks;

namespace Link.Modules
{
    public class WorldEnteringModule : ProtoModuleBase
    {
        public int RoleId { get; set; }
        public ManualResetEventSlim EnteringWaiter { get; private set; }
        public bool AutoEnter { get; set; }
        public bool Entered
        {
            get
            {
                return EnteringWaiter.IsSet;
            }
            private set
            {
                if (EnteringWaiter.IsSet == value)
                {
                    return;
                }
                if (value)
                {
                    EnteringWaiter.Set();
                }
                else
                {
                    EnteringWaiter.Reset();
                }
                EnteredChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler EnteredChanged;

        public int EnterWorldTimeout { get; set; }

        public WorldEnteringModule()
        {
            EnteringWaiter = new ManualResetEventSlim(false);
            AutoEnter = true;
        }

        public void Select(int roleId)
        {
            var selectRole = Proto.Get<SelectRole>();
            selectRole.RoleId = roleId;
            Session.Send(selectRole);
        }

        public override void RegisterHandlers()
        {
            Register<SelectRole_Re>(SelectRoleReReceive);
            Register<SelectRole>(SelectRoleReceive);
            Register(0x00, ContainerReceive);
        }
        public override void Initialize()
        {
            base.Initialize();

            Session.StateChanged += Session_StateChanged;
        }

        private void Session_StateChanged(object sender, EventArgs e)
        {
            Entered = false;
        }

        private void SelectRoleReceive(object sender, PacketEventArgs e)
        {
            var selectRole = e.Read<SelectRole>();

            RoleId = selectRole.RoleId.Value;
        }
        private void SelectRoleReReceive(object sender, PacketEventArgs e)
        {
            var selectRoleRe = e.Packet.ReadPacket<SelectRole_Re>();

            if (selectRoleRe.Result == 0 && e.Chain.IsInput && !e.IsComplete && AutoEnter)
            {
                var enterWorld = Proto.Get<EnterWorld>();
                enterWorld.RoleId = RoleId;

                if (EnterWorldTimeout > 0)
                {
                    Task.Delay(EnterWorldTimeout).ContinueWith(x => e.Chain.Redirect.SendPacket(enterWorld));
                }
                else
                {
                    e.Chain.Redirect.SendPacket(enterWorld);
                }
            }
        }
        private void ContainerReceive(object sender, PacketEventArgs e)
        {
            Entered = true;
        }
    }
}

