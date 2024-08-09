using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Network
{
    // ICommunicator - интерфейс для общения по сети
    public interface ICommunicator : IDisposable
    {
        // Send - отправка сообщения message по сети
        void Send(string message);

        // Receive - получение сообщения по сети
        string Receive();
    }
}
