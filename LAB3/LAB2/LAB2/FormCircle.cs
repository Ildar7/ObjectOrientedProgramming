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
    public partial class FormCircle : Form
    {
        private Circle circle;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormCircle(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            circle = new Circle(pic, bmp,cmbbx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, r = 0;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                r = int.Parse(setW.Text);
                circle.DeleteF(circle, true);
                circle = new Circle(x, y, r * 2, pic, bmp, cmbbx);
                circle.Draw();
                BDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewXY_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                circle.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewWH_Click(object sender, EventArgs e)
        {
            int r = 0;
            try
            {
                r = int.Parse(newW.Text);
                circle.ChangeRadiusTo(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCi_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
