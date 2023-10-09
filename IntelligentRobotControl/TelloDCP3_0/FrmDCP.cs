﻿using System;
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
