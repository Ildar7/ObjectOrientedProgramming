using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FLib;

namespace LAB4
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private ComboBox cmbbx_plug;
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();
                try
                {
                    string commandText = textBoxInputString.Text.Replace(" ", "");
                    for (int i = 0; i < commandText.Length; i++)
                    {
                        char symbol = commandText[i];
                        if (IsNotOperation(symbol))
                        {
                            if (!Char.IsDigit(symbol))
                            {
                                operands.Push(new Operand(symbol));
                                while (i < commandText.Length - 1 && IsNotOperation(commandText[i + 1]))
                                {
                                    string temp_str = operands.Pop().value.ToString() + commandText[i + 1].ToString();
                                    operands.Push(new Operand(temp_str));
                                    i++;
                                }
                            }
                            else if (Char.IsDigit(symbol))
                            {
                                operands.Push(new Operand(symbol.ToString()));
                                while (i < commandText.Length - 1 && Char.IsDigit(commandText[i + 1])
                                    && IsNotOperation(commandText[i + 1]))
                                {
                                    int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                        (int)Char.GetNumericValue(commandText[i + 1]);
                                    operands.Push(new Operand(temp_num.ToString()));
                                    i++;
                                }
                            }
                        }

                        else if ((symbol == 'E') || (symbol == 'M') || (symbol == 'D') || (symbol == 'A'))
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(symbol));
                            }
                        }
                        else if (symbol == '(')
                        {
                            operators.Push(OperatorContainer.FindOperator(symbol));
                        }
                        else if (symbol == ')')
                        {
                            do
                            {
                                if (operators.Peek().symbolOperator == '(')
                                {
                                    operators.Pop();
                                    break;
                                }
                                if (operators.Count == 0)
                                {
                                    break;
                                }
                            }
                            while (operators.Peek().symbolOperator != '(');
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Аргументы введены некорректно.");
                    comboBox1.Items.Add("Аргументы введены некорректно.");
                }
                try
                {
                    SelectingPerformingOperation(operators.Peek());
                }
                catch
                {
                    MessageBox.Show("Введенной операции не существует.");
                    comboBox1.Items.Add("Введенной операции не существует.");
                }
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'E')
            {
                if (operands.Count == 5)
                {
                    int h = Convert.ToInt32(operands.Pop().value.ToString());
                    int w = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (!((y < 0) || (y + h > pictureBox1.Height) || (x < 0) || (x + w > pictureBox1.Width)))
                    {
                        Ellipse ellipse = new Ellipse(name, x, y, w, h, pictureBox1, bitmap, cmbbx_plug);
                        ellipse.Draw();
                        comboBox1.Items.Add($"Нарисован эллипс {ellipse.name}.");
                    }
                    else
                    {
                        MessageBox.Show("Фигура не может выйти за пределы границ :(");
                        comboBox1.Items.Add("Фигура не может выйти за пределы границ :(");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор E принимает 5 аргументов.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора E.");
                }
            }
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Ellipse ellipse = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Ellipse el in Flist.figures)
                    {
                        if(el.name == name)
                        {
                            ellipse = el;
                        }
                    }
                    if (ellipse != null)
                    {
                        if (!((y < 0) || (y + ellipse.height > pictureBox1.Height) || (x < 0) ||
                            (x + ellipse.width > pictureBox1.Width)))
                        {
                            ellipse.MoveTo(x, y);
                            comboBox1.Items.Add($"Эллипс {ellipse.name} перемещен.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура не может выйти за пределы границ :(");
                            comboBox1.Items.Add("Фигура не может выйти за пределы границ :(");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора M.");
                }
            }
            else if (op.symbolOperator == 'A')
            {
                if (operands.Count == 2)
                {
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    foreach (Ellipse el in Flist.figures.ToArray())
                    {
                        if (!((el.y + y < 0) || (el.y + y + el.height > pictureBox1.Height) ||
                            (el.x + x < 0) || (el.x + x + el.width > pictureBox1.Width)))
                        {
                            el.ShiftTo(x, y);
                            comboBox1.Items.Add($"Эллипс {el.name} перемещен.");
                        }
                        else
                        {
                            MessageBox.Show($"Эллипс {el.name} не может выйти за пределы границ :(");
                            comboBox1.Items.Add($"Эллипс {el.name} не может выйти за пределы границ :(");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Опертор A принимает 2 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора A.");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Ellipse ellipse = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Ellipse el in Flist.figures)
                    {
                        if (el.name == name)
                        {
                            ellipse = el;
                        }
                    }
                    if (ellipse != null)
                    {
                        ellipse.DeleteF(ellipse, true);
                        comboBox1.Items.Add($"Эллипс {ellipse.name} успешно удален.");
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'A' || item == 'D' || item == 'M' || item == 'E' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonClearCommandList_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
