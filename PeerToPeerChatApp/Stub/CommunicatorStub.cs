using PeerToPeerChatApp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Stub
{
    internal class CommunicatorStub : ICommunicator
    {
        private Random random = new Random();

        public string Receive()
        {
            Thread.Sleep(random.Next(5000, 15000));
            return $"сообщение от CommunicatorStub, время {DateTime.UtcNow}";
        }

        public void Send(string message)
        {
            //
        }
        public void Dispose()
        {
            //
        }
    }
}
