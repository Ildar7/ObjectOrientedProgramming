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
    public partial class FormSquare : Form
    {
        private Square square;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormSquare(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            square = new Square(pic, bmp, cmbbx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                w = int.Parse(setW.Text);
                square.DeleteF(square, true);
                square = new Square(x, y, w, pic, bmp, cmbbx);
                square.Draw();
                BDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSQ_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BNewXY_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                square.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewWH_Click(object sender, EventArgs e)
        {
            int w = 0;
            try
            {
                w = int.Parse(newW.Text);
                square.ChangeSizeTo(w);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelWH_Click(object sender, EventArgs e)
        {

        }

        private void setW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
