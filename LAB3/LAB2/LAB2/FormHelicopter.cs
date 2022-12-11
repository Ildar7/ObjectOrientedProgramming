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
    public partial class FormHelicopter : Form
    {
        private Helicopter helicopter;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormHelicopter(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            helicopter = new Helicopter(pic, bmp, cmbbx);
            BNewXY.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void FormHelicopter_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(setX.Text);
                int y = int.Parse(setY.Text);
                helicopter.DeleteF(helicopter, true);
                helicopter = new Helicopter(x, y, pic, bmp, cmbbx);
                helicopter.Draw();
                BDraw.Enabled = false;
                if (!((y < 0) || (y + 160 > pic.Height) || (x < 0) || (x + 320 > pic.Width)))
                {
                    BNewXY.Enabled = true;
                }
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
                helicopter.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
