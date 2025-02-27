﻿using PeerToPeerChatApp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Stub
{
    internal class ConnectorStub : ConnectorBase
    {

        public ConnectorStub(string ipStr, int port) { 
            localEndPoint = new IPEndPoint(IPAddress.Parse(ipStr), port);
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(ipStr), port + 1);
        }

        public override ICommunicator Connect()
        {
            return new CommunicatorStub();
        }

        public override ICommunicator WaitConnection()
        {
            return new CommunicatorStub();
        }

        public override void Disconnect()
        {
            // 
        }

        public override void Dispose()
        {
            // 
        }
    }
}
