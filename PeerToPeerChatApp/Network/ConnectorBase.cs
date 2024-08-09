using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PeerToPeerChatApp.Network
{
    // ConnectorBase - абстрактный класс, описывающий поведение для установления и разрыва сетевых соединений
    internal abstract class ConnectorBase : IDisposable
    {
        // endpoint-ы между которыми установлено соединение
        protected IPEndPoint localEndPoint;
        protected IPEndPoint remoteEndPoint;

        public ConnectorBase(string localIpStr, int localPort, string remoteIpStr, int remotePort)
        {
            localEndPoint = new IPEndPoint(IPAddress.Parse(localIpStr), localPort);
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(remoteIpStr), remotePort);
        }

        // свойства строк endpoint-ов
        public string LocalEndPointStr {  get { return localEndPoint.ToString(); } }
        public string RemoteEndPointStr { get { return remoteEndPoint.ToString(); } }

        // АБСТРАКТНЫЕ МЕТОДЫ КОННЕКТОРА

        // Connect - установить соединение по сети
        public abstract ICommunicator Connect();

        // WaitConnection - ожидать входящего соединения по сети
        public abstract ICommunicator WaitConnection();

        // Disconnect - отключиться, закрыв открытые соединения
        public abstract void Disconnect();

        // Финализатор
        public abstract void Dispose();
    }
}
