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
    public partial class ThirdTask : Form
    {
        public ThirdTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numsList = new List<int>();
            foreach (int items in listBox1.Items)
            {
                numsList.Add(items);
            }

            int maxNum = 0;

            for (int i = 0; i < numsList.Count; i++)
            {
                maxNum = Math.Max(numsList[i], maxNum);
            }

            int indexOfMaxNum = numsList.IndexOf(maxNum);

            for (int i = 0; i < numsList.Count; i++)
            {
                if (i != indexOfMaxNum)
                {
                    listBox1.Items[i] = numsList[i] * (-1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string thisText = textBox1.Text;
            try
            {
                int thisNum = int.Parse(thisText);
                listBox1.Items.Add(thisNum);
            } catch
            {
                MessageBox.Show("Пожалуйста, введите только целые числа!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
