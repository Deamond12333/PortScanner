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
        public bool isStart = false;
        public Thread scanThread;
        public MainWindow()
        {
            InitializeComponent();
            hostBox.Text = "127.0.0.1";
            scan_button.Text = "Сканировать";
        }

        public void Scan()
        {
            int StartPort = Convert.ToInt32(portsTo.Value);
            int EndPort = Convert.ToInt32(portsFrom.Value);
            int i, j = 0;

            if (isScanAllPorts.Checked)
            {
                StartPort = 1;
                EndPort = 9999;
            }

            if (EndPort < StartPort)
            {
                int buffer = StartPort;
                StartPort = EndPort;
                EndPort = buffer;
            }

            this.Invoke(new Action(delegate
            {
                progress_bar.Maximum = EndPort - StartPort + 1;
                progress_bar.Value = 0;
                listview_scanner.Items.Clear();
            }));

            IPAddress IpAddr = IPAddress.Parse(hostBox.Text);
            for (i = StartPort; i <= EndPort; i++)
            {
                //Создаем сокет
                IPEndPoint IpEndP = new IPEndPoint(IpAddr, i);
                Socket MySoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Пробуем подключится к указанному хосту
                IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP, new AsyncCallback(ConnectCallback), MySoc);

                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    MySoc.Close();
                    this.Invoke(new Action(delegate
                    {
                        progress_bar.Value += 1;
                        if (isJustOpenPorts.Checked) return;
                        listview_scanner.Items.Add("Порт " + i.ToString());
                        listview_scanner.Items[j].SubItems.Add("закрыт");
                        listview_scanner.Items[j].BackColor = Color.Bisque;
                        j++;
                    }));
                }
                else
                {
                    MySoc.Close();
                    this.Invoke(new Action(delegate
                    {
                        progress_bar.Value += 1;
                        listview_scanner.Items.Add("Порт " + i.ToString());
                        listview_scanner.Items[j].SubItems.Add("открыт");
                        listview_scanner.Items[j].BackColor = Color.LightGreen;
                        j++;
                    }));
                }
            }

            this.Invoke(new Action(delegate
            {
                progress_bar.Value = 0;
                scan_button.Text = "Сканировать";
                isStart = false;
            }));
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
            isStart = !isStart;
            if (!isStart)
            {
                scan_button.Text = "Сканировать";
                scanThread.Abort();
                progress_bar.Value = 0;
            }
            else
            {
                scan_button.Text = "Остановить";
                scanThread = new Thread(Scan);
                scanThread.Start();
            }
        }

        private void isScanAllPorts_CheckedChanged(object sender, EventArgs e)
        {
            portsTo.Enabled = !portsTo.Enabled;
            portsFrom.Enabled = !portsFrom.Enabled;
        }
    }
}