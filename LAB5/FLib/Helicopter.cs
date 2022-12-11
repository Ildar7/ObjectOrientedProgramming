using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//namespace FLib
//{
//    public class Helicopter : Figure
//    {
//        public List<Figure> figures = null;
//        public ComboBox cmbbx;
//        public Rectangle re;
//        public Square sq;
//        public Ellipse el;
//        public Circle ci;
//        public Triangle tg;
//        public Helicopter(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p, b, cmbbx)
//        {
//            this.cmbbx = cmbbx;
//        }
//        public Helicopter(int x, int y, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(x, y, 320, 160, pictureBox, b, cmbbx)
//        {
//            figures = new List<Figure>();
//            this.cmbbx = cmbbx;
//            re = new Rectangle(x, y, 200, 20, pictureBox, b, cmbbx);
//            sq = new Square(x + 85, y + 25, 30, pictureBox, b, cmbbx);
//            el = new Ellipse(x + 20, y + 60, 160, 100, pictureBox, b, cmbbx);
//            ci = new Circle(x + 285, y + 15, 40, pictureBox, b, cmbbx);
//            Point p1 = new Point(x + 185, y + 60);
//            Point p2 = new Point(x + 185, y + 120);
//            Point p3 = new Point(x + 320, y + 60);
//            Point[] points = { p1, p2, p3 };
//            tg = new Triangle(points, pictureBox, b, cmbbx);
//            Figure[] f_list = { re, sq, el, ci, tg };
//            figures.AddRange(f_list);
//        }
//        public override void Draw()
//        {
//            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
//            {
//                foreach (Figure f in figures)
//                {
//                    f.Draw();
//                }
//            }
//            else MessageBox.Show("Фигура не может выйти за пределы границ :(");
//        }
//        public override void MoveTo(int x, int y)
//        {
//            if (!((y < 0) || (y + height > pictureBox.Height) || (x < 0) || (x + width > pictureBox.Width)))
//            {
//                re.MoveTo(x, y);
//                sq.MoveTo(x + 85, y + 25);
//                el.MoveTo(x + 20, y + 60);
//                ci.MoveTo(x + 285, y + 15);
//                tg.MoveTo(x + 185, y + 60);
//            }
//            else MessageBox.Show("Фигура не может выйти за пределы границ :(");
//        }
//        public override void DeleteF(Figure figure, bool flag)
//        {
//            if (figures != null)
//            {
//                foreach (Figure f in figures)
//                {
//                    f.DeleteF(f, true);
//                }
//            }
//            if (flag == true)
//            {
//                Flist.figures.Remove(figure);
//                Clear();
//                foreach (Figure f in Flist.figures)
//                {
//                    f.Draw();
//                }
//                pictureBox.Image = bitmap;
//            }
//            else
//            {
//                Flist.figures.Remove(figure);
//                Clear();
//                foreach (Figure f in Flist.figures)
//                {
//                    f.Draw();
//                }
//                Flist.figures.Add(figure);
//                pictureBox.Image = bitmap;
//            }
//        }
//    }
//}
