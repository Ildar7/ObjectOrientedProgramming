using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLib;

namespace OOPLAB2
{
    public partial class FormPolygon : Form
    {
        int i;
        int numPoints;
        bool flag;
        Point[] points;
        Polygon polygon;

        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormPolygon(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            polygon = new Polygon(pic, bmp, cmbbx);
            flag = false;
            i = 0;
            BDraw.Enabled = false;
            BNewXY.Enabled = false;
        }

        private void BsetDots_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(dots_count.Text);
                if (n <= 2)
                {
                    MessageBox.Show("Укажите как минимум 3 точки");
                    numPoints = 0;
                }
                else
                {
                    i = 0;
                    numPoints = n;
                    points = new Point[numPoints];
                    BAddDot.Enabled = true;
                    BsetDots.Enabled = false;
                    dots_count.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BAddDot_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(setX.Text);
                int y = int.Parse(setY.Text);
                points[i].X = x;
                points[i].Y = y;
                i += 1;
                if (i == numPoints)
                {
                    BAddDot.Enabled = false;
                    BDraw.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            polygon.DeleteF(polygon, true);
            polygon = new Polygon(points, pic, bmp, cmbbx);
            polygon.Draw();
            BNewXY.Enabled = true;
            BDraw.Enabled = false;
        }

        private void BNewXY_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(newX.Text);
                int y = int.Parse(newY.Text);
                polygon.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void FormPolygon_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void dots_count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
