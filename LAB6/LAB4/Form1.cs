using System;
using System.Drawing;
using System.Windows.Forms;
using CommandExecutor;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            General.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            General.cmbbx_main = comboBox1;
            General.picturebox_main = pictureBox1;
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                General.Execute(textBoxInputString.Text);
            }
        }

        private void buttonClearCommandList_Click_1(object sender, EventArgs e)
        {
            General.ClearComands();
        }
    }
}
