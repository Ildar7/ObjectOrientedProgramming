using FLib;

namespace OOPLAB2
{
    public partial class FormEllipse : Form
    {
        private Ellipse ellipse;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        private ComboBox cmbbx;
        public FormEllipse(PictureBox pic, Bitmap bmp, Button butt, ComboBox cmbbx)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            ellipse = new Ellipse(pic, bmp, cmbbx);
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0, h = 0;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                w = int.Parse(setW.Text);
                h = int.Parse(setH.Text);
                if(IsInBounds(ellipse, x, y))
                {
                    ellipse.DeleteF(ellipse, true);
                    ellipse = new Ellipse(x,y,w,h,pic,bmp,cmbbx);
                    ellipse.Draw();
                }
                BDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsInBounds(Figure f, int x, int y)
        {
            if ((y < 0) || (y + f.height > pic.Height) || (x < 0) || (x + f.width > pic.Width) || f == null)
            {
                throw new Exception("Фигура за пределами границ, измените размеры!");
            }
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void FormEl_MouseDown(object sender, MouseEventArgs e)
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
                ellipse.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewWH_Click(object sender, EventArgs e)
        {
            int w = 0, h = 0;
            try
            {
                w = int.Parse(newW.Text);
                h = int.Parse(newH.Text);
                ellipse.ChangeSizeTo(w, h);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
