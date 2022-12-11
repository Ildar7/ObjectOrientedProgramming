using System;
using System.Drawing;
using System.Windows.Forms;

namespace FLib
{
    public class Triangle : Polygon
    {
        public Triangle(PictureBox p, Bitmap b, ComboBox cmbbx) : base(p, b, cmbbx) { }
        public Triangle(Point[] points, PictureBox pictureBox, Bitmap b, ComboBox cmbbx) : base(points, pictureBox, b, cmbbx) { }
    }
}

