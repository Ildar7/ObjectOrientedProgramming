using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace FLib
{
    public class Ellipse : Figure
    {
        public string name;
        public Ellipse(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p, b, cmbbx) { }
        public Ellipse(int x, int y, int w, int h, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, w, h, pictureBox, b, cmbbx) { }
        public Ellipse(string name, int x, int y, int w, int h, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, w, h, pictureBox, b, cmbbx)
        {
            this.name = name;
        }
        //рисуем эллипс
        public override void Draw()
        {
            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawEllipse(pen, x, y, width, height);
                pictureBox.Image = bitmap;
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
        //передвигаем эллипс
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
        //изменить размер эллипса
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
