using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelloDCP3_0
{
    public partial class FrmDCP : Form
    {
        static FrmDCP frmCli;
        static UdpClient udpCli, udpSvr;
        static FrmCam wCam;
        static FrmFp wRoom;
        static Thread tUDPServer;
        public bool tBusy;
        private bool abortRun;
        public long T_time;
        StreamWriter swLog;
        public bool cmdDone = true;


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

                if (cbStatus.Checked)
                    lbStatus.Items.Add(ep.ToString() + ": " + rd);
                dataProc90(rd);
            }
            lbStatus.Items.Add("Server disconnected.");
            udpSvr.Close();
        }

        private void dataProc90(string pStr)
        {
            long dt = DateTime.Now.Ticks;

            if (pStr[0] != 'p')
                return;

            //"pitch:%d;roll:%d;yaw:%d;vgx:%d;vgy:%d;vgz:%d;templ:%d;temph:%d;tof:%d;
            //h:%d;bat:%d;baro:%.2f;time:%d;agx:%.2f;agy:%.2f;agz:%.2f;\r\n"

            string[] dd = pStr.Split(';');
            long mtime = (DateTime.Now.Ticks - T_time) / TimeSpan.TicksPerMillisecond;
            string msg = mtime + ", ";

            msg += dd[10].Substring(4) + ", ";
            msg += dd[2].Substring(4) + ", ";
            msg += dd[9].Substring(2) + ", ";
            msg += dd[8].Substring(4) + ", ";
            msg += dd[11].Substring(5);
            if (cbLog.Checked && swLog != null)
                swLog.WriteLine(msg);

            lbHead.Text = dd[2].Substring(4);
            lbAlt.Text = dd[9].Substring(2);
            lbBatt.Text = dd[10].Substring(4);
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
        public void udpcommand(string msg, int tout)
        {
            udpCli.BeginReceive(new AsyncCallback(ReceiveCallback), udpCli);

            IPEndPoint target = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);
            Byte[] senddata = Encoding.ASCII.GetBytes(msg);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            udpcommand(cbCommand.Text, 50);
        }

        private void btnTakeoff_Click(object sender, EventArgs e)
        {
            udpcommand("takeoff",50);
        }
        private void btnLand_Click(object sender, EventArgs e)
        {
            udpcommand("land",50);
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
        private void FrmDCP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wCam != null)
                wCam.Close();
            tBusy = false;
            try
            {
                tUDPServer.Abort();
                udpSvr.Close();
                udpCli.Close();
            }
            catch (Exception ex) { };
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbEdit.Text = "";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text File(*.txt)|*.txt|모든파일 (*.*)|*.*";
            od.Title = "Open a Text File";
            od.ShowDialog();
            if (od.FileName != "")
                tbEdit.Text = File.ReadAllText(od.FileName);
        }

        private void btnPtfly_Click(object sender, EventArgs e)
        {
            wRoom = new FrmFp(this);
            wRoom.Show();
            wRoom.Location = new Point(this.Left + 150, this.Top);
        }

        private void flightPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wRoom = new FrmFp(this);
            wRoom.Show();
            wRoom.Location = new Point(this.Left + 150, this.Top);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbCode.Items.Clear();
            for (int i = 0; i < tbEdit.Lines.Length; i++)
            {
                if (Parsing(tbEdit.Lines[i]) >= 0)
                    lbCode.Items.Add(tbEdit.Lines[i]);
            }
        }

        public string[] mCmd = { "TakeOff", "Land", "Move", "Rotate", "Shift", "UpDown" };

        private int Parsing(string cLine)
        {
            for (int i = 0; i < mCmd.Length; i++)
            {
                if (Regex.IsMatch(cLine, "``b" + mCmd[i] + "``b"))
                    return i;
            }
            return -1;
        }

        private void autoRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbCode.Items.Count <= 0)
                return;
            abortRun = false;
            btnStop.Enabled = true;
            for (int line = 0; line < lbCode.Items.Count; line++)
            {
                lbCode.SelectedIndex = line;
                //ExeCmd(1stCmd.SelectItem.ToString());
                sleep50ms(5);
                if (abortRun) break;
            }
            btnStop.Enabled = false;
            lbCode.SelectedIndex = 0;
        }

        private void sleep50ms(int ms50)
        {
            for (int i = 0; i < ms50; i++)
            {
                Thread.Sleep(50);
                Application.DoEvents();
                if (abortRun)
                    break;
            }
        }

        private void stepRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbCode.Items.Count <= 0)
                return;
            //ExecCmd(lbCode.SelectedItem.ToString();
            if (lbCode.SelectedIndex == lbCode.Items.Count - 1)
                lbCode.SelectedIndex = 0;
            else
                lbCode.SelectedIndex++;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            abortRun = true;
        }

        private void cbLog_CheckedChanged(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + @"\DcpData";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += string.Format(@"\Tello{0}.txt", DateTime.Now.Ticks);

            if (cbLog.Checked)
            {
                swLog = File.CreateText(path);
                swLog.WriteLine("%{0}: time, bat, yaw, h, tof, baro", DateTime.Now);
                swLog.Flush();
                T_time = DateTime.Now.Ticks;
            }
            else
            {
                swLog.Close();
            }
        }

        private void brnUp_Click(object sender, EventArgs e)
        {
            udpcommand("up 30", 50);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            udpcommand("down 30", 50);
        }
        
        private void btnYawmi_Click(object sender, EventArgs e)
        {
            udpcommand("cw 90", 50);
        }

        private void btnYawplus_Click(object sender, EventArgs e)
        {
            udpcommand("cw 270", 50);
        }

        private void btnUparrow_Click(object sender, EventArgs e)
        {
            udpcommand("forward 150", 50);
        }

        private void btnLeftarrow_Click(object sender, EventArgs e)
        {
            udpcommand("left 30", 50);
        }

        private void btnRightarrow_Click(object sender, EventArgs e)
        {
            udpcommand("right 30", 50);
        }

        private void btnDownarrow_Click(object sender, EventArgs e)
        {
            udpcommand("backward 150", 50);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text File(*.txt)|*.txt|모든파일 (*.*)|*.*";
            sd.Title = "Save a Text File";
            sd.ShowDialog();
            if (sd.FileName != "")
                File.WriteAllText(sd.FileName, tbEdit.Text);
        }

    }
}
