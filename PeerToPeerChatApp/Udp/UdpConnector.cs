using PeerToPeerChatApp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Udp
{
    // UdpConnector - коннектор, работающий на основе протокола UDP
    internal class UdpConnector : ConnectorBase
    {
        private Socket socket;  // udp-сокет через который будет осуществляться общение 
        public UdpConnector(string localIpStr, int localPort, string remoteIpStr, int remotePort)
            : base(localIpStr, localPort, remoteIpStr, remotePort)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(localEndPoint);
        }

        public override ICommunicator WaitConnection()
        {
            throw new NotImplementedException();
        }

        public override ICommunicator Connect()
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
