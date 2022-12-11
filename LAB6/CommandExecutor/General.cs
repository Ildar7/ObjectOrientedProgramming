using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FLib;

namespace CommandExecutor
{
    public static class General
    {
        public static Bitmap bitmap;
        public static ComboBox cmbbx_plug;
        public static ComboBox cmbbx_main;
        public static PictureBox picturebox_main;
        static Stack<Operator> operators = new Stack<Operator>();
        static Stack<Operand> operands = new Stack<Operand>();
        public static void Execute(string s)
        {
            operators.Clear();
            operands.Clear();
            try
            {
                string sourceExpression = s.Replace(" ", "");
                for (int i = 0; i < sourceExpression.Length; i++)
                {
                    char c = sourceExpression[i];
                    if (IsNotOperation(c))
                    {
                        if (!Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c));
                            while (i < sourceExpression.Length - 1 && IsNotOperation(sourceExpression[i + 1]))
                            {
                                string temp_str = operands.Pop().value.ToString() + sourceExpression[i + 1].ToString();
                                operands.Push(new Operand(temp_str));
                                i++;
                            }
                        }
                        else if (Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c.ToString()));
                            while (i < sourceExpression.Length - 1 && Char.IsDigit(sourceExpression[i + 1])
                                && IsNotOperation(sourceExpression[i + 1]))
                            {
                                int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                    (int)Char.GetNumericValue(sourceExpression[i + 1]);
                                operands.Push(new Operand(temp_num.ToString()));
                                i++;
                            }
                        }
                    }

                    else if ((c == 'E') || (c == 'M') || (c == 'D') || (c == 'A'))
                    {
                        if (operators.Count == 0)
                        {
                            operators.Push(OperatorContainer.FindOperator(c));
                        }
                    }
                    else if (c == '(')
                    {
                        operators.Push(OperatorContainer.FindOperator(c));
                    }
                    else if (c == ')')
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
                cmbbx_main.Items.Add("Аргументы введены некорректно.");
            }
            try
            {
                SelectingPerformingOperation(operators.Peek());
            }
            catch
            {
                MessageBox.Show("Введенной операции не существует.");
                cmbbx_main.Items.Add("Введенной операции не существует.");
            }
        }
        static void SelectingPerformingOperation(Operator op)
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
                    if (!((y < 0) || (y + h > picturebox_main.Height) || (x < 0) || (x + w > picturebox_main.Width)))
                    {
                        Ellipse ellipse = new Ellipse(name, x, y, w, h, picturebox_main, bitmap, cmbbx_plug);
                        ellipse.Draw();
                        cmbbx_main.Items.Add($"Нарисован эллипс {ellipse.name}.");
                    }
                    else
                    {
                        MessageBox.Show("Фигура не может выйти за пределы границ :(");
                        cmbbx_main.Items.Add("Фигура не может выйти за пределы границ :(");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор E принимает 5 аргументов.");
                    cmbbx_main.Items.Add("Неверное число аргументов для оператора E.");
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
                        if (el.name == name)
                        {
                            ellipse = el;
                        }
                    }
                    if (ellipse != null)
                    {
                        if (!((y < 0) || (y + ellipse.height > picturebox_main.Height) || (x < 0) ||
                            (x + ellipse.width > picturebox_main.Width)))
                        {
                            ellipse.MoveTo(x, y);
                            cmbbx_main.Items.Add($"Эллипс {ellipse.name} перемещен.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура не может выйти за пределы границ :(");
                            cmbbx_main.Items.Add("Фигура не может выйти за пределы границ :(");
                        }
                    }
                    else
                    {
                        cmbbx_main.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    cmbbx_main.Items.Add("Неверное число аргументов для оператора M.");
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
                        if (!((el.y + y < 0) || (el.y + y + el.height > picturebox_main.Height) ||
                            (el.x + x < 0) || (el.x + x + el.width > picturebox_main.Width)))
                        {
                            el.ShiftTo(x, y);
                            cmbbx_main.Items.Add($"Эллипс {el.name} перемещен.");
                        }
                        else
                        {
                            MessageBox.Show($"Эллипс {el.name} не может выйти за пределы границ :(");
                            cmbbx_main.Items.Add($"Эллипс {el.name} не может выйти за пределы границ :(");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Опертор A принимает 2 аргумента.");
                    cmbbx_main.Items.Add("Неверное число аргументов для оператора A.");
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
                        cmbbx_main.Items.Add($"Эллипс {ellipse.name} успешно удален.");
                    }
                    else
                    {
                        cmbbx_main.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумент.");
                    cmbbx_main.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }
        static bool IsNotOperation(char item)
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

        public static void ClearComands()
        {
            cmbbx_main.Items.Clear();
        }
    }
}
