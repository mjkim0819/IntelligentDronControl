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

namespace TelloTest
{
    public partial class FrmClient : Form
    {
        static FrmClient frmCli;
        static UdpClient udpCli;

        public FrmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            frmCli = this;
        }
        private void FrmClient_Load(object sender, EventArgs e)
        {
            udpCli = new UdpClient(5145);
        }
        public static void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient sock = ar.AsyncState as UdpClient;
            IPEndPoint source = new IPEndPoint(IPAddress.Any, 0);
            byte[] message = sock.EndReceive(ar, ref source);
            string receiveString = Encoding.ASCII.GetString(message);

            frmCli.listBox1.Items.Add(source.ToString() + ": " + receiveString);
            sock.BeginReceive(new AsyncCallback(ReceiveCallback), sock);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IAsyncResult asyncResult = udpCli.BeginReceive(new AsyncCallback(ReceiveCallback), udpCli);

            IPEndPoint target = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5142);
            Byte[] senddata = Encoding.ASCII.GetBytes(textBox1.Text);

            udpCli.Send(senddata, senddata.Length, target);
        }
    }
}
