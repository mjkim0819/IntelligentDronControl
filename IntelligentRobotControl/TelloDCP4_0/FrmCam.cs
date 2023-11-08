using Emgu.CV;
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

namespace TelloDCP4_0
{
    public partial class FrmCam : Form
    {
        UdpClient udpSvr;
        static FrmDCP pWin;
        static FrmCam tWin;
        Thread tCam;
        bool tStarted = false;
        VideoCapture vCap;
        public FrmCam(FrmDCP par)
        {
            InitializeComponent();
            pWin = par;
            udpSvr = new UdpClient(11111);
        }
        private void FrmCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnStart.Enabled == false)
                btnStop.PerformClick();
            if (udpSvr != null)
                udpSvr.Close();
        }
        private void FrmCam_Load(object sender, EventArgs e)
        {
            tWin = this;
        }
        private void CamCallback()
        {
            IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            vCap = new VideoCapture(0);
            Mat frame = new Mat();
            while (tStarted)
            {
                Byte[] buf;
                frame = vCap.QueryFrame();
                // if (frame != null)
                pbTcam.Image = frame.ToBitmap();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            pWin.udpcommand("streamom", 10);
            tCam = new Thread(new ThreadStart(CamCallback));
            tCam.Start();
            tStarted = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tStarted = false;
            pWin.udpcommand("streamoff", 10);
            try
            {
                udpSvr.Close();
                tCam.Abort();
            }
            catch (Exception ex) { };
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
