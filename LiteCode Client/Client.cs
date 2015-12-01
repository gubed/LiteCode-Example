using LiteCode;
using SecureSocketProtocol3;
using SecureSocketProtocol3.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiteCode_Client
{
    public class Client : SSPClient
    {
        public Client()
            : base(new ClientProps())
        {

        }
        private static ISharedClass builder;
        private static LiteCodeClient liteCode;
        public override void onConnect()
        {
            liteCode = new LiteCodeClient(this);
            liteCode.Connect();
        }
        public void Initialize()
        {
            builder = liteCode.GetSharedClass<ISharedClass>("SharedClass", null);
        }
        public string getSecretData()
        {
            // call remote function from server
            return builder.secretData();
        }
        public override void onDisconnect(DisconnectReason Reason)
        {

        }

        public override void onException(Exception ex, ErrorType errorType)
        {

        }
        public override void onOperationalSocket_Connected(OperationalSocket OPSocket)
        {

        }

        public override void onOperationalSocket_BeforeConnect(OperationalSocket OPSocket)
        {

        }

        public override void onOperationalSocket_Disconnected(OperationalSocket OPSocket, DisconnectReason Reason)
        {

        }
        public override void onBeforeConnect()
        {
            base.RegisterOperationalSocket(new LiteCodeClient(this));
        }
    }
}
