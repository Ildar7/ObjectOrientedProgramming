using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{

    public partial class FourthTask : Form
    {
        public FourthTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        public bool checkInputs()
        {
            if (
                textBox1.Text.Length <= 0 && textBox2.Text.Length <= 0 && textBox3.Text.Length <= 0
                && textBox4.Text.Length <= 0 && textBox5.Text.Length <= 0 && textBox6.Text.Length <= 0
                )
            {
                MessageBox.Show("Для указания полной информации о работнике все поля должны быть заполнены!");
                return false;
            }

            string fio = textBox1.Text;
            string salary = textBox3.Text;
            string yearOfAdmission = textBox2.Text;
            string allowance = textBox4.Text;
            string workedInMonth = textBox5.Text;
            string workingDaysOfMonth = textBox6.Text;

            if (Regex.IsMatch(fio, @"^\d+$"))
            {
                MessageBox.Show("Строка ФИО не может содержать цифр!");
                return false;
            }

            if (fio.Split(' ').Length < 3)
            {
                MessageBox.Show("Введите полное ФИО через пробел!");
                return false;
            }

            try
            {
                double salaryNum = double.Parse(salary);
                double allowanceNum = double.Parse(allowance);

                if ((allowance.Split(',').Length == 2) && (allowance.Split(',')[0] == "0"))
                {
                    try
                    {
                        int yearOfAdmissionNum = int.Parse(yearOfAdmission);
                        int workedInMonthNum = int.Parse(workedInMonth);
                        int workingDaysOfMonthNum = int.Parse(workingDaysOfMonth);

                        if (yearOfAdmissionNum > 2022)
                        {
                            MessageBox.Show("Год поступления на работу не можеты быть больше текущего года!");
                            return false;
                        }

                        if (workedInMonthNum > workingDaysOfMonthNum)
                        {
                            MessageBox.Show("Вы не можете отработать больше, чем кол-во рабочих дней в месяце!");
                            return false;
                        }

                        if (workingDaysOfMonthNum > 23)
                        {
                            MessageBox.Show("Кол-во рабочих дней в месяце в среднем не превышает 23 дней!");
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Строки 'год поступления на работу', 'кол-во отработанных дней в месяце', 'кол-во рабочих дней в месяце' " +
                            "не могут быть числами с плавающей запятой или содержать буквы!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Значение коэффициента не должно превышать 1 и обязательно должно быть числом с плавающей запятой!");
                    return false;
                }

            }
            catch
            {
                MessageBox.Show("Строка 'оклад' и 'процент надбавки' не могут содержать букв или быть пустыми! Проверьте правильность введенных данных");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                string fio = textBox1.Text;
                double salary = double.Parse(textBox3.Text);
                int yearOfAdmission = int.Parse(textBox2.Text);
                double allowance = double.Parse(textBox4.Text);
                int workedInMonth = int.Parse(textBox5.Text);
                int workingDaysOfMonth = int.Parse(textBox6.Text);

                Payment userInfo = new Payment(fio, salary, yearOfAdmission, allowance, workedInMonth, workingDaysOfMonth);
                MessageBox.Show("Имя работника: " + userInfo.Fio 
                    + "\nНачисления: " + userInfo.CalculateAccuredAmount() + " руб."
                    + "\nКол-во отработанных дней в месяце: " + userInfo.WorkedInMonth + " дней"
                    + "\nКол-во рабочих дней в месяце: " + userInfo.WorkingDaysOfMonth + " дней"
                    );
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                string fio = textBox1.Text;
                double salary = double.Parse(textBox3.Text);
                int yearOfAdmission = int.Parse(textBox2.Text);
                double allowance = double.Parse(textBox4.Text);
                int workedInMonth = int.Parse(textBox5.Text);
                int workingDaysOfMonth = int.Parse(textBox6.Text);

                Payment userInfo = new Payment(fio, salary, yearOfAdmission, allowance, workedInMonth, workingDaysOfMonth);
                MessageBox.Show("Имя работника: " + userInfo.Fio
                    + "\nУдержания: " + userInfo.CalculateWithheldAmount() + " руб."
                    + "\nКол-во отработанных дней в месяце: " + userInfo.WorkedInMonth + " дней"
                    + "\nКол-во рабочих дней в месяце: " + userInfo.WorkingDaysOfMonth + " дней"
                    );
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                string fio = textBox1.Text;
                double salary = double.Parse(textBox3.Text);
                int yearOfAdmission = int.Parse(textBox2.Text);
                double allowance = double.Parse(textBox4.Text);
                int workedInMonth = int.Parse(textBox5.Text);
                int workingDaysOfMonth = int.Parse(textBox6.Text);

                Payment userInfo = new Payment(fio, salary, yearOfAdmission, allowance, workedInMonth, workingDaysOfMonth);
                MessageBox.Show("Имя работника: " + userInfo.Fio
                    + "\nСумма, выдаваемая на руки: " + userInfo.CalculateAmountOnHand() + " руб."
                    + "\nКол-во отработанных дней в месяце: " + userInfo.WorkedInMonth + " дней"
                    + "\nКол-во рабочих дней в месяце: " + userInfo.WorkingDaysOfMonth + " дней"
                    );
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                string fio = textBox1.Text;
                double salary = double.Parse(textBox3.Text);
                int yearOfAdmission = int.Parse(textBox2.Text);
                double allowance = double.Parse(textBox4.Text);
                int workedInMonth = int.Parse(textBox5.Text);
                int workingDaysOfMonth = int.Parse(textBox6.Text);

                Payment userInfo = new Payment(fio, salary, yearOfAdmission, allowance, workedInMonth, workingDaysOfMonth);
                MessageBox.Show("Имя работника: " + userInfo.Fio
                    + "\nСтаж работы: " + userInfo.CalculateWorkExperience() + " лет"
                    + "\nКол-во отработанных дней в месяце: " + userInfo.WorkedInMonth + " дней"
                    + "\nКол-во рабочих дней в месяце: " + userInfo.WorkingDaysOfMonth + " дней"
                    );
            }
        }

    }

    public class Payment
    {
        private double tax = 0.13; // Фиксированный налог 13%
        private int year = 2022;
        public string Fio { get; set; }
        private double salary;
        private int yearOfAdmission;
        private double allowance;
        public int WorkedInMonth { get; set; }
        public int WorkingDaysOfMonth { get; set; }
        private double accuredAmount; // Начисленная сумма
        private double withheldAmount; // Удержанная сумма
        private double amountOnHand; // Сумма, выдаваемая на руки
        private int workExperience; // Стаж работы

        
        public Payment(
                string fio, // ФИО
                double salary, // Оклад
                int yearOfAdmission, // Год поступления на работу
                double allowance, // Процент надбавки
                int workedInMonth, // Отработано дней за месяц
                int workingDaysOfMonth // Кол-во рабочих дней в месяц
            )
        {
            Fio = fio;
            this.salary = salary;
            this.yearOfAdmission = yearOfAdmission;
            this.allowance = allowance;
            WorkedInMonth = workedInMonth;
            WorkingDaysOfMonth = workingDaysOfMonth;
        }

        public double CalculateAccuredAmount()
        {
            accuredAmount = this.salary + this.salary * this.allowance;
            return accuredAmount;
        }

        public double CalculateWithheldAmount()
        {
            accuredAmount = this.salary + this.salary * this.allowance;
            withheldAmount = accuredAmount * 0.01 + this.salary * tax;
            return withheldAmount;
        }

        public double CalculateAmountOnHand()
        {
            accuredAmount = this.salary + this.salary * this.allowance;
            withheldAmount = accuredAmount * 0.01 + this.salary * tax;
            amountOnHand = accuredAmount - withheldAmount;
            return amountOnHand;
        }

        public int CalculateWorkExperience()
        {
            workExperience = year - this.yearOfAdmission;
            return workExperience;
        }
    }
}
