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
    public partial class FifthTask : Form
    {
        public FifthTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0 && textBox2.Text.Length <= 0)
            {
                MessageBox.Show("Пожалуйста, введите кол-во строк и столбцов!");
                return;
            }
            string mValue = textBox1.Text;
            string nValue = textBox2.Text;
            try
            {
                int mNum = int.Parse(mValue);
                int nNum = int.Parse(nValue);

                

                dataGridView1.RowCount = mNum;
                dataGridView1.ColumnCount = nNum;

                dataGridView1.TopLeftHeaderCell.Value = "Матрица";
                Random rnd = new Random();

                for (int i = 0; i < mNum; i++)
                {
                    for (int j = 0; j < nNum; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-99, 99);
                        dataGridView1.Columns[j].Width = 28;
                    }
                }
            } catch
            {
                MessageBox.Show("Ввод чисел с плавающей запятой и строк запрещен!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0 && dataGridView1.Columns.Count <= 0)
            {
                MessageBox.Show("Пожалуйста, заполните матрицу нажатием кнопки 'Построить матрицу'!");
            } else
            {
                double maxElemInTable = -9999;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (Math.Abs((int)dataGridView1.Rows[i].Cells[j].Value) > maxElemInTable)
                        {
                            maxElemInTable = Math.Abs((int)dataGridView1.Rows[i].Cells[j].Value);
                        }
                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = (int)dataGridView1.Rows[i].Cells[j].Value / maxElemInTable;
                        dataGridView1.Columns[j].Width = 100;
                    }
                }
            }
        }
    }
}
