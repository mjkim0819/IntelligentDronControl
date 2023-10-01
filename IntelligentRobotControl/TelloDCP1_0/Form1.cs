using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelloDCP1_0
{
    public partial class FrmDCP : Form
    {
        static FrmDCP frmCli;
        static UdpClient udpCli;
        public FrmDCP()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            udpCli = new UdpClient(8889);
            frmCli = this;
        }
        public static void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient sock = ar.AsyncState as UdpClient;
            IPEndPoint source = new IPEndPoint(IPAddress.Any, 0);
            byte[] message = sock.EndReceive(ar, ref source);
            string receiveString = Encoding.ASCII.GetString(message);

            frmCli.lbStatus.Items.Add(source.ToString() + ": " + receiveString);
            sock.BeginReceive(new AsyncCallback(ReceiveCallback), sock);
        }
        private void udpcommand(string msg)
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

        }
    }
}
