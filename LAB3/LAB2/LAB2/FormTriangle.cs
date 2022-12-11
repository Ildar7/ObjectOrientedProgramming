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
    public partial class FormTriangle : Form
    {
        Triangle tg;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormTriangle(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            tg = new Triangle(pic, bmp, cmbbx);
            BNewXY.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(setX1.Text);
                int y1 = int.Parse(setY1.Text);
                int x2 = int.Parse(setX2.Text);
                int y2 = int.Parse(setY2.Text);
                int x3 = int.Parse(setX3.Text);
                int y3 = int.Parse(setY3.Text);
                Point pt1 = new Point(x1, y1);
                Point pt2 = new Point(x2, y2);
                Point pt3 = new Point(x3, y3);
                Point[] points = { pt1, pt2, pt3 };
                tg.DeleteF(tg, true);
                tg = new Triangle(points, pic, bmp, cmbbx);
                tg.Draw();
                BNewXY.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewXY_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(newX.Text);
                int y = int.Parse(newY.Text);
                tg.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormTriangle_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
