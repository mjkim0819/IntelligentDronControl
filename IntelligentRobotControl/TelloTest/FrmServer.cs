using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelloTest
{
    public partial class FrmServer : Form
    {
        private Thread thdUDPServer;
        private UdpClient udpSvr;
        private bool tBusy = false;
        public FrmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        private void FrmServer_Load(object sender, EventArgs e)
        {
            FrmClient win = new FrmClient();
            win.Show();
            win.Location = new Point(this.Location.X + win.Width, this.Location.Y);

            thdUDPServer = new Thread(new ThreadStart(serverThread));
            tBusy = true;
            thdUDPServer.Start();
        }
        private void serverThread()
        {
            udpSvr = new UdpClient(5142);
            listBox1.Items.Add("Waiting for Client....");

            while (tBusy)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpSvr.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                listBox1.Items.Add(RemoteIpEndPoint.ToString() + ": " + returnData);

                if (returnData == "quit")
                    tBusy = false;
                if (checkbox1.Checked)
                    udpSvr.Send(receiveBytes, receiveBytes.Length, RemoteIpEndPoint);

            }
            listBox1.Items.Add("Server disconnected.");
        }
        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            tBusy = false;
            try
            {
                thdUDPServer.Abort();
                udpSvr.Close();
            }
            catch (Exception ex) { }
        }
    }
}
