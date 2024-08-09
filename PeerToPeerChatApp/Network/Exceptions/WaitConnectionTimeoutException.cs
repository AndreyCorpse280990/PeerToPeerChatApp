using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Network.Exceptions
{
    // WaitConnectionTimeoutException - ошибка таймаута ожидания подключения
    internal class WaitConnectionTimeoutException : ApplicationException
    {
        public WaitConnectionTimeoutException()
            : base("waait connection timeout")
        { 
        
        }
    }
}
