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

namespace TelloDCP2_0
{
    public partial class FrmDCP : Form
    {
        static FrmDCP frmCli;
        static UdpClient udpCli, udpSvr;
        static FrmCam wCam;
        static Thread tUDPServer;
        public bool tBusy;

        public FrmDCP()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            frmCli = this;
        }
        public void severThread()
        {
            udpSvr = new UdpClient(8890);
            lbStatus.Items.Add("Waiting for Tello status...");

            while (tBusy)
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
                Byte[] rb = udpSvr.Receive(ref ep);
                string status = BitConverter.ToString(rb);
                string rd = Encoding.ASCII.GetString(rb);

                lbStatus.Items.Add(ep.ToString() + ": " + rd);
            }
            lbStatus.Items.Add("Sever disconnected.");
            udpSvr.Close();
        }
        public static void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient sock = ar.AsyncState as UdpClient;
            IPEndPoint source = new IPEndPoint(IPAddress.Any, 0);
            byte[] message = sock.EndReceive(ar, ref source);
            string receiveString = Encoding.ASCII.GetString(message);

            frmCli.lbComm.Items.Add(source.ToString() + ": " + receiveString);
            sock.BeginReceive(new AsyncCallback(ReceiveCallback), sock);
        }
        public void udpcommand(string msg)
        {
            udpCli.BeginReceive(new AsyncCallback(ReceiveCallback), udpCli);

            IPEndPoint target = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);
            Byte[] senddata = Encoding.ASCII.GetBytes(msg);

            frmCli.lbComm.Items.Add(">>" + msg);
            udpCli.Send(senddata, senddata.Length, target);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            udpcommand(cbCommand.Text);
        }

        private void btnTakeoff_Click(object sender, EventArgs e)
        {
            udpcommand("takeoff");
        }
        private void btnLand_Click(object sender, EventArgs e)
        {
            udpcommand("land");
        }
        private void FrmDCP_Load(object sender, EventArgs e)
        {
            frmCli = this;
            udpCli = new UdpClient(8889);
            tUDPServer = new Thread(new ThreadStart(severThread));
            tBusy = true;
            tUDPServer.Start();
        }
        private void btnCam_Click(object sender, EventArgs e)
        {
            wCam = new FrmCam(this);
            wCam.Show();
            wCam.Location = new Point(this.Right, this.Top);
        }
    }
}
