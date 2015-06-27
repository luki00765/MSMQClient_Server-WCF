using System;
using System.Windows;
using MSMQClient.MSMQServiceReference;

namespace MSMQClient
{
    public partial class MainWindow : Window
    {
        private MSMQServiceClient client;

        public MainWindow()
        {
            InitializeComponent();
            client = new MSMQServiceClient();
        }

        private void buttonSendMsg_Click(object sender, RoutedEventArgs e)
        {
            client.SendLockMessage(textBox1.Text,DateTime.Now);
            client.SendToOutputWindow(textBox1.Text,DateTime.Now);
        }
    }
}
