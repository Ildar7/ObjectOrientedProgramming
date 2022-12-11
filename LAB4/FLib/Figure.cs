using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FLib
{
    public abstract class Figure
    {
        public Figure(PictureBox p, Bitmap b, ComboBox cmbbx)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            pictureBox = p;
            bitmap = b;
            Flist.figures.Add(this);
            cmbbx.Items.Add(this);
        }
        public Figure(int x, int y, PictureBox p, Bitmap b, ComboBox cmbbx)
        {
            this.x = x;
            this.y = y;
            this.width = 0;
            this.height = 0;
            pictureBox = p;
            bitmap = b;
            Flist.figures.Add(this);
        }
        public Figure(int x, int y, int w, int h, PictureBox p, Bitmap b, ComboBox cmbbx)
        {
            this.x = x;     
            this.y = y;
            this.width = w; 
            this.height = h;
            pictureBox = p;
            bitmap = b;
            Flist.figures.Add(this);
        }
        public PictureBox pictureBox;
        public Bitmap bitmap; 
        public Pen pen = new Pen(Color.Black, 3);
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set;}
        public int height { get; set; }
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public virtual void DeleteF(Figure figure, bool flag)
        {
            if(flag == true)
            {
                Flist.figures.Remove(figure);
                Clear();
                foreach (Figure f in Flist.figures)
                {
                    f.Draw();
                }
                pictureBox.Image = bitmap;
            }
            else
            {
                Flist.figures.Remove(figure);
                Clear();
                foreach (Figure f in Flist.figures)
                {
                    f.Draw();
                }
                Flist.figures.Add(figure);
                pictureBox.Image = bitmap;
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox.Image = bitmap;
        }
    }
}
