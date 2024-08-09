using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Network.Exceptions
{
    // ReceiveTimeoutException - ошибка таймаута получения сообщения
    internal class ReceiveTimeoutException : ApplicationException
    {
        public ReceiveTimeoutException() :
            base("receive timeout")
        { 

        }
    }
}
