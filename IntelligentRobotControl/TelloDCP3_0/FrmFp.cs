using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelloDCP3_0
{
    public partial class FrmFp : Form
    {
        FrmDCP pWin;
        public FrmFp(FrmDCP par)
        {
            InitializeComponent();
            pWin = par;
        }
        private void FrmFp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(pWin.Location.X + 180, pWin.Location.Y + 65);
            drawGrid();
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
            int w = pbRoom.Size.Width; // pbRoom 사이즈에 맞게 그리드 사이즈 +a
            int h = pbRoom.Size.Width;
            int inc = tbGrid.Value;

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
    }
}
