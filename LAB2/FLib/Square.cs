using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FLib
{
    public class Square : Rectangle
    {
        public Square(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p,b,cmbbx) { }
        public Square(int x, int y, int w, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, w, w, pictureBox,b, cmbbx) { }
        //рисуем квадрат
        public override void Draw()
        {
            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawRectangle(pen, x, y, width, width);
                pictureBox.Image = bitmap;
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
        //передвигаем прямоугольник
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
        //изменить размер квадрата
        public void ChangeSizeTo(int w)
        {
            if (!((y < 0) || (y + w > pictureBox.Height) || (x < 0) || (x + w > pictureBox.Width)))
            {
                width = w; height = w;
                DeleteF(this, false);
                Draw();
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
    }
}
