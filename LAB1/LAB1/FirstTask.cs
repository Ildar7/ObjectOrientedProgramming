using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class FirstTask : Form
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void FirstTask_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xStr = textBox1.Text;
            string yStr = textBox2.Text;
            string zStr = textBox3.Text;

            try
            {
                double x = double.Parse(xStr);
                double y = double.Parse(yStr);
                double z = double.Parse(zStr);
                double l = 2 * Math.Max(x, z) - 3 * Math.Min(Math.Min(x,y), z);
                MessageBox.Show("Ответ: " + l);
            } catch
            {
                MessageBox.Show("Пожалуйста, введите только действительные числа!");
            }
        }
    }
}
