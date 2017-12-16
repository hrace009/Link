using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Link.Modules
{
    public class ReconnectorModule : ModuleBase
    {
        public override void Destroy()
        {
            Session.StateChanged -= Session_StateChanged;
        }

        public Connector Connector { get; private set; }
        public int Timeout { get; set; } = 5000;

        public override void Initialize()
        {
            Connector = Session.Modules.Register<Connector>();
            Session.StateChanged += Session_StateChanged;
        }

        private void Session_StateChanged(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                return;
            }
            if (Session.State == Net.SessionState.Closed)
            {
                if (Timeout > 0)
                {
                    Task.Delay(Timeout).ContinueWith(x => Connector.Connect());
                }
                else
                {
                    Connector.Connect();
                }
            }
        }
    }
}
