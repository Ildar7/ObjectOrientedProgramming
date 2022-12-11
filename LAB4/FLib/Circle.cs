using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FLib
{
    public class Circle : Ellipse
    {
        public Circle(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p,b,cmbbx) { }
        public int diametr;
        public Circle(int x, int y, int d, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, d, d, pictureBox,b,cmbbx)
        {
            diametr = d;
        }
        //рисуем круг
        public override void Draw()
        {
            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawEllipse(pen, x, y, diametr, diametr);
                pictureBox.Image = bitmap;
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
        //передвигаем круг
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
        //изменить радиус круга
        public void ChangeRadiusTo(int r)
        {
            if (!((y < 0) || (y + (2 * r) > pictureBox.Height) || (x < 0) || (x + (2 * r) > pictureBox.Width)))
            {
                diametr = 2 * r;
                DeleteF(this, false);
                Draw();
            }
            else MessageBox.Show("Фигура не может выйти за пределы границ :(");;
        }
    }
}
