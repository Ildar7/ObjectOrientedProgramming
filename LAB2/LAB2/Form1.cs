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
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void buttonEL_Click(object sender, EventArgs e)
        {
            FormEllipse el = new FormEllipse(pictureBox1, bitmap, buttonEL, comboBox1);
            el.Show();
            buttonEL.Enabled = false;
        }

        private void buttonRE_Click(object sender, EventArgs e)
        {
            FormRectangle re = new FormRectangle(pictureBox1, bitmap, buttonRE, comboBox1);
            re.Show();
            buttonRE.Enabled = false;
        }

        private void buttonSQ_Click(object sender, EventArgs e)
        {
            FormSquare sq = new FormSquare(pictureBox1, bitmap, buttonSQ, comboBox1);
            sq.Show();
            buttonSQ.Enabled = false;
        }

        private void buttonCI_Click(object sender, EventArgs e)
        {
            FormCircle ci = new FormCircle(pictureBox1, bitmap, buttonCI, comboBox1);
            ci.Show();
            buttonCI.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(Flist.figures.Count() > 0)
            {
                Flist.figures[0].Clear();
                Flist.figures.Clear();
                comboBox1.Items.Clear();
            }
        }

        private void buttonClearThis_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                Flist.figures[comboBox1.SelectedIndex].DeleteF(Flist.figures[comboBox1.SelectedIndex], true);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.SelectedItem = null;
            }
        }
    }

}
