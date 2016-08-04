using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PortScanner
{
    public partial class MainWindow : Form
    {
        public static ManualResetEvent connectDone = new ManualResetEvent(false);
        public MainWindow()
        {

            InitializeComponent();
            hostBox.Text = "127.0.0.1";
        }

        public void Scan()
        {
            int StartPort = Convert.ToInt32(portsTo.Value);
            int EndPort = Convert.ToInt32(portsFrom.Value);
            int i;

            progress_bar.Maximum = EndPort - StartPort + 1;
            progress_bar.Value = 0;
            listview_scanner.Items.Clear();


            IPAddress IpAddr = IPAddress.Parse(hostBox.Text);
            for (i = StartPort; i <= EndPort; i++)
            {
                //Создаем сокет
                IPEndPoint IpEndP = new IPEndPoint(IpAddr, i);
                Socket MySoc = new Socket(AddressFamily.InterNetwork,
                                         SocketType.Stream, ProtocolType.Tcp);
                //Пробуем подключится к указанному хосту
                IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP,
                                 new AsyncCallback(ConnectCallback), MySoc);


                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    MySoc.Close();
                    listview_scanner.Items.Add("Порт " + i.ToString());
                    listview_scanner.Items[i - StartPort].SubItems.Add("закрыт");
                    listview_scanner.Items[i - StartPort].BackColor = Color.Bisque;
                    progress_bar.Value += 1;
                }
                else
                {
                    MySoc.Close();
                    listview_scanner.Items.Add("Порт " + i.ToString());
                    listview_scanner.Items[i - StartPort].SubItems.Add("открыт");
                    listview_scanner.Items[i - StartPort].BackColor = Color.LightGreen;
                    progress_bar.Value += 1;
                }
            }

            progress_bar.Value = 0;
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket SockClient = (Socket)ar.AsyncState;
                SockClient.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {

            }
        }

        private void scan_button_Click(object sender, EventArgs e)
        {
            Scan();
        }

    }
}