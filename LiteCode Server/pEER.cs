using LiteCode;
using SecureSocketProtocol3;
using SecureSocketProtocol3.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiteCode_Server
{

    public class Peer : SSPClient
    {
        public Peer()
            : base()
        {

        }
        public override void onConnect()
        {
            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] User \"" + base.Username + "\" connected, Peer connected " + base.RemoteIp);
        }

        public override void onDisconnect(DisconnectReason Reason)
        {

        }

        public override void onException(Exception ex, ErrorType errorType)
        {
            Console.WriteLine(ex.Message);
        }

        public override void onBeforeConnect()
        {
            base.RegisterOperationalSocket(new LiteCodeClient(this));
        }

        public override void onOperationalSocket_Connected(OperationalSocket OPSocket)
        {

        }

        public override void onOperationalSocket_BeforeConnect(OperationalSocket OPSocket)
        {
            if (OPSocket as LiteCodeClient != null)
            {
                LiteCodeClient liteClient = OPSocket as LiteCodeClient;
                liteClient.ShareClass("SharedClass", typeof(SharedBuilder), false, 1, null);
            }
        }

        public override void onOperationalSocket_Disconnected(OperationalSocket OPSocket, DisconnectReason Reason)
        {

        }
    }


}
