using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelloDCP3_0
{
    public partial class FrmFp : Form
    {
        private void FrmFp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(pWin.Location.X + 180, pWin.Location.Y + 65);
            pbRoom.Controls.Add(pbDrone);
            drawGrid();
        }
        FrmDCP pWin;
        public FrmFp(FrmDCP par)
        {
            InitializeComponent();
            pWin = par;
        }
        public struct WPoint
        {
            public Point p;
            public int Deg, Alt;
        }
        WPoint[] mPoint = new WPoint[50];
        int wIndex = -1;
        private void drawGrid()
        {
            int x, y;
            int w = pbRoom.BackgroundImage.Size.Width;
            int h = pbRoom.BackgroundImage.Size.Height;
            int inc = tbGrid.Value;
            //int w = this.Size.Width;
            //int h = this.Size.Height;

            Pen myPen = new Pen(Color.GreenYellow);
            Bitmap bmp = new Bitmap(pbRoom.BackgroundImage);

            Graphics gr = Graphics.FromImage(bmp);

            for (x = 0; x <= w; x += inc)
                gr.DrawLine(myPen, x, 0, x, h);

            for (y = 0; y <= h; y += inc)
                gr.DrawLine(myPen, 0, y, w, y);

            gr.Dispose();
            pbRoom.Image = bmp;
            drawPath(0);

        }
        private void drawPath(int flg)
        {
            int rr = 4;
            double deg, x, y;
            Point p, _p;
            Pen myPen = new Pen(Color.LightCoral);
            Bitmap bmp = new Bitmap(pbRoom.Image);
            Graphics gr = Graphics.FromImage(bmp);

            for (int i = flg; i <= wIndex; i++)
            {
                p = trimPoint(mPoint[i].p);
                tbAlt.Value = mPoint[i].Alt;
                myPen.Width = 5;
                gr.DrawEllipse(myPen, p.X - rr / 2, p.Y - rr / 2, rr, rr);
                gr.DrawString(tbAlt.Value.ToString(), new Font("Arial", 10),
                    new SolidBrush(Color.Red), p.X, p.Y - 20);
                myPen.Width = 1;
                if (i > 0)
                {
                    p = trimPoint(mPoint[i].p);
                    _p = trimPoint(mPoint[i - 1].p);
                    gr.DrawLine(myPen, p, _p);
                    x = p.X - _p.X;
                    y = p.Y - _p.Y;
                    deg = Math.Atan2(y, x) * 180 / Math.PI;
                    mPoint[wIndex - 1].Deg = Convert.ToInt32(deg);
                }
            }

            gr.Dispose();
            pbRoom.Image = bmp;
            pbRoom.Invalidate();
        }

        private Point trimPoint(Point p)
        {
            double scale = (double)pbRoom.Image.Width / (double)pbRoom.Width;
            p.X = (int)(p.X * scale);
            p.Y = (int)(p.Y * scale);
            return p;
        }

        private void tbGrid_Scroll(object sender, EventArgs e)
        {
            drawGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wIndex = -1;
            drawGrid();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            int np, st = 5, deg = 0;
            int x, y;
            double xx, yy, dp, th;
            Image drone = pbDrone.Image;

            for (int i = 0; i < wIndex; i++)
            {
                pbDrone.Visible = false;
                tbAlt.Value = mPoint[i].Alt;
                x = mPoint[i].p.X - pbDrone.Width / 2;
                y = mPoint[i].p.Y - pbDrone.Height / 2;
                pbDrone.Location = new Point(x, y);
                deg = deg - mPoint[i].Deg;
                if (deg < -180)
                    deg += 360;
                if (deg > 180)
                    deg -= 360;
                pbDrone.Image = RotateImage(pbDrone.Image, deg);
                deg = mPoint[i].Deg;
                pbDrone.Visible = true;
                pbRoom.Refresh();

                Thread.Sleep(500);
                th = deg + Math.PI / 180;
                xx = mPoint[i + 1].p.X - mPoint[i].p.X;
                yy = mPoint[i + 1].p.Y - mPoint[i].p.Y;
                dp = Math.Sqrt(xx * xx + yy * yy);
                np = (int)(dp / st + 1);
                for (int n = 0; n < np; n++)
                {
                    pbDrone.Visible = false;
                    xx = n * st * Math.Cos(th);
                    yy = n * st * Math.Sin(th);
                    pbDrone.Location = new Point(x + (int)xx, y + (int)yy);
                    pbDrone.Visible = true;
                    pbRoom.Refresh();
                    Thread.Sleep(30);
                }
            }
            pbDrone.Image = drone;
        }

        private Bitmap RotateImage(Image img, int deg)
        {
            Bitmap rbmp = new Bitmap(img.Width, img.Height);
            rbmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            Graphics gr = Graphics.FromImage(rbmp);
            int offset = img.Width / 2;

            gr.TranslateTransform(offset, offset);
            gr.RotateTransform(-deg);
            gr.TranslateTransform(-offset, -offset);
            gr.DrawImage(img, new PointF(0, 0));

            return rbmp;
        }

        private void pbRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (wIndex < 50)
                ++wIndex;
            mPoint[wIndex].p = e.Location;
            mPoint[wIndex].Alt = tbAlt.Value;

            drawPath(wIndex);
        }
    }
}
