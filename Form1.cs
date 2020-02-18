using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Калькулятор_Инженерный
{
    public partial class Form1 : Form
    {
       

        float a, b; // переменные для подсчетов где не требуется переменная double
        double d, c; // переменные для подсчетов там где требуется их наличие К примеру логорифм, и т.д почти все из  библиотеки match
        int cout; // переменная нужная для вывода и предварительных подсчетов моего калькулятора
        bool suka = true; // переменная нужная ждя присвоения знака действия
       
      
        //передача значений
     
        
        enum Azazelo { q = 0, q2, q3, q4, q5, q6, q7, q8, q9, q10 }; // Делаем перечисление. Хз как его применить дальше.

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 7;

        }

        private void button18_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 6;
        }

        private void button22_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 2;
        }

        private void button21_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 8;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 9;
        }

        private void button23_Click(object sender, EventArgs e) // кнопка постановки запятой, разделение числа дополнительное
        {

            textBox1.Text = textBox1.Text + ",";
        }
        private void button6_Click(object sender, EventArgs e) // кнопка вычитания с послед. ее присвоением
        {

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 2;
            label1.Text = a.ToString() + "-";
            suka = true;
        }
        private void button7_Click(object sender, EventArgs e) // кнопка умножения с последующим ее присвоением
        {

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 3;
            label1.Text = a.ToString() + "*";
            suka = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e) // Кнопка Сложения с последующим присвоением
        {

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 1;
            label1.Text = a.ToString() + "+";
            suka = true;

        }

        private void button8_Click(object sender, EventArgs e) // присвоение знака деление и отображение его на экране пользователя
        {

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 4;
            label1.Text = a.ToString() + "/";
            suka = true;
        }
        private void calculate() // Подсчет Основного функционала калькулятора, идет отдельно так как возникают конфликты при подсчете
        {
            switch (cout)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text); // сложение
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text); // вычитание
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text); // умножение
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text); // деление
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a / 100 * float.Parse(textBox1.Text); // Возведение процентов
                    textBox1.Text = b.ToString();
                    break;


                default:
                    break;
            }

        }
        private void button10_Click(object sender, EventArgs e) // кнопка равно используется не везде, так как не нужна
        {
            calculate();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // кнопка полного очищения (C)
        {
            int lenght = textBox1.Text.Length - 10000;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button12_Click(object sender, EventArgs e) // Кнопка подсчета процентов от числа
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 5;
            label1.Text = a.ToString() + "%";
            suka = true;
        }

        private void button4_Click_1(object sender, EventArgs e) // Кнопка возведение в Степень
        {
            d = Convert.ToInt32(textBox1.Text);
            suka = true;
            d = Math.Pow(d, 2);
            label1.Text = Convert.ToString(d);

        }
        private void button3_Click(object sender, EventArgs e) // кнопка постепенного очищения bakcspase
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button13_Click_1(object sender, EventArgs e) // кнопка возведения в модуль
        {
            a = Convert.ToInt32(textBox1.Text);
            suka = false;
            if (a < 0)
            {
                a = a * (-1);
                label1.Text = Convert.ToString(a);
            }
            else
            {
                label1.Text = Convert.ToString(a);
            }

        }

        private void button11_Click(object sender, EventArgs e) // кнопка подсчета лгорифма
        {
            d = Convert.ToInt32(textBox1.Text);
            suka = true;
            d = Math.Log10(d);
            label1.Text = Convert.ToString(d);

        }

        private void button26_Click(object sender, EventArgs e) // подсчет квадратного корня
        {
            d = Convert.ToInt32(textBox1.Text);
            suka = true;
            d = Math.Sqrt(d);
            label1.Text = Convert.ToString(d);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }// end 1; ***********************

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }//end 3 *********************

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }// end3 *****************************************************

        private void button25_Click(object sender, EventArgs e) // Режим сложения матриц
        {
            textBox20.Text = (int.Parse(textBox2.Text) + int.Parse(textBox11.Text)).ToString();
            textBox21.Text = (int.Parse(textBox3.Text) + int.Parse(textBox12.Text)).ToString();
            textBox22.Text = (int.Parse(textBox4.Text) + int.Parse(textBox13.Text)).ToString();
            textBox23.Text = (int.Parse(textBox5.Text) + int.Parse(textBox14.Text)).ToString();
            textBox24.Text = (int.Parse(textBox6.Text) + int.Parse(textBox15.Text)).ToString();
            textBox25.Text = (int.Parse(textBox7.Text) + int.Parse(textBox16.Text)).ToString();
            textBox26.Text = (int.Parse(textBox8.Text) + int.Parse(textBox17.Text)).ToString();
            textBox27.Text = (int.Parse(textBox9.Text) + int.Parse(textBox18.Text)).ToString();
            textBox28.Text = (int.Parse(textBox10.Text) + int.Parse(textBox19.Text)).ToString();
        }

        private void button27_Click(object sender, EventArgs e) // Режим умножения матриц
        {
            textBox20.Text = ((int.Parse(textBox2.Text) * int.Parse(textBox11.Text)) + (int.Parse(textBox5.Text) * int.Parse(textBox12.Text)) + (int.Parse(textBox8.Text) * int.Parse(textBox13.Text))).ToString();
            textBox23.Text = ((int.Parse(textBox2.Text) * int.Parse(textBox14.Text)) + (int.Parse(textBox5.Text) * int.Parse(textBox15.Text)) + (int.Parse(textBox8.Text) * int.Parse(textBox16.Text))).ToString();
            textBox26.Text = ((int.Parse(textBox2.Text) * int.Parse(textBox17.Text)) + (int.Parse(textBox5.Text) * int.Parse(textBox18.Text)) + (int.Parse(textBox8.Text) * int.Parse(textBox19.Text))).ToString();
            textBox21.Text = ((int.Parse(textBox3.Text) * int.Parse(textBox11.Text)) + (int.Parse(textBox6.Text) * int.Parse(textBox12.Text)) + (int.Parse(textBox9.Text) * int.Parse(textBox13.Text))).ToString();
            textBox24.Text = ((int.Parse(textBox3.Text) * int.Parse(textBox14.Text)) + (int.Parse(textBox6.Text) * int.Parse(textBox15.Text)) + (int.Parse(textBox9.Text) * int.Parse(textBox16.Text))).ToString();
            textBox27.Text = ((int.Parse(textBox3.Text) * int.Parse(textBox17.Text)) + (int.Parse(textBox6.Text) * int.Parse(textBox18.Text)) + (int.Parse(textBox9.Text) * int.Parse(textBox19.Text))).ToString();
            textBox22.Text = ((int.Parse(textBox4.Text) * int.Parse(textBox11.Text)) + (int.Parse(textBox7.Text) * int.Parse(textBox12.Text)) + (int.Parse(textBox10.Text) * int.Parse(textBox13.Text))).ToString();
            textBox25.Text = ((int.Parse(textBox4.Text) * int.Parse(textBox14.Text)) + (int.Parse(textBox7.Text) * int.Parse(textBox15.Text)) + (int.Parse(textBox10.Text) * int.Parse(textBox16.Text))).ToString();
            textBox28.Text = ((int.Parse(textBox4.Text) * int.Parse(textBox17.Text)) + (int.Parse(textBox7.Text) * int.Parse(textBox18.Text)) + (int.Parse(textBox10.Text) * int.Parse(textBox19.Text))).ToString();
        }

  

   
        private void button24_Click(object sender, EventArgs e) // кнопка присвоения знака использоуется для убирания при необходимости
        {
            if (suka == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                suka = false;
            }
            else if (suka == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                suka = true;

            }

        }
    }

}
