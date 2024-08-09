using PeerToPeerChatApp.Network;
using PeerToPeerChatApp.Stub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeerToPeerChatApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // обработчик ожидания подключения
        private void waitConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessConnection(true);
        }

        // обработчик инициирования подключения
        private void connectionButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessConnection(false);
        }

        private void ProcessConnection(bool isWaitingConnection)
        {
            try
            {
                // достанем данные для ожидания подключения
                string localIpStr = localIpTextBox.Text;
                int localPort = Convert.ToInt32(localPortTextBox.Text);
                string remoteIpStr = remoteIpTextBox.Text;
                int remotePort = Convert.ToInt32(remotePortTextBox.Text);
                // используя эти данные создадим нужный коннектор
                using (ConnectorBase connector = new ConnectorStub(localIpStr, localPort))
                {
                    // ожидать подключение или подключиться
                    ICommunicator communicator = isWaitingConnection? 
                        connector.WaitConnection() : 
                        connector.Connect();
                    // скрыть текущую форму
                    Hide();
                    // создать и открыть в диалогом режиме форму для общения
                    ChatWindow chatWindow = new ChatWindow(
                        connector.LocalEndPointStr,
                        connector.RemoteEndPointStr,
                        communicator
                    );
                    chatWindow.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Show(); // показать текущую форму снова
            }
        }
    }
}
