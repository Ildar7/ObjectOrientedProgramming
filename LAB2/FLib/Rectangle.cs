using System;
using System.Drawing;
using System.Windows.Forms;

namespace FLib
{
    public class Rectangle : Figure
    {
        public Rectangle(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p, b, cmbbx) { }
        public Rectangle(int x, int y, int w, int h, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, w, h, pictureBox, b, cmbbx) { }
        public override void Draw()
        {
            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawRectangle(pen, x, y, width, height);
                pictureBox.Image = bitmap;
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");
        }
        public override void MoveTo(int x, int y)
        {
            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
            {
                this.x = x; this.y = y;
                DeleteF(this, false);
                Draw();
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
        public void ChangeSizeTo(int w, int h)
        {
            if (!((y < 0) || (y + h > pictureBox.Height) || (x < 0) || (x + w > pictureBox.Width)))
            {
                width = w; height = h;
                DeleteF(this, false);
                Draw();
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
    }
}
