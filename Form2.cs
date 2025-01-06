using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conventor
{
    public partial class Form2 : Form
    {

        bool Plus = false, Minus = false, Multiple = false, Power = false,
            Devide = false, Percent = false, equal = false, Root = false;
        double result1, result2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void number(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += ((Button)sender).Text.ToString();
            }
            else
            {
                textBox1.Text = ((Button)sender).Text.ToString();
            }

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
           
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Plus = true;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Plus == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);
                    double my_result = result1 + result2;
                    textBox1.Text = my_result.ToString();
                    Plus = false;

                }
                else if (Minus == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);
                    double my_result = result1 - result2;
                    textBox1.Text = my_result.ToString();
                    Minus = false;
                }
                else if (Multiple == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);
                    double my_result = result1 * result2;
                    textBox1.Text = my_result.ToString();
                    Multiple = false;
                }
                else if (Devide == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);

                    if (result2 != 0)
                    {
                        result2 = Convert.ToDouble(textBox1.Text);
                        double my_result = result1 / result2;
                        textBox1.Text = my_result.ToString();
                        Devide = false;
                    }
                    else
                    {
                        MessageBox.Show("تقسیم بر صفر مجاز نیست!!!");
                    }

                }
                else if (Percent == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);
                    double my_result = result1 % result2;
                    textBox1.Text = my_result.ToString();
                    Percent = false;
                }
                else if (Power == true)
                {
                    result2 = Convert.ToDouble(textBox1.Text);
                    double my_result = Math.Pow(result1, result2);
                    textBox1.Text = my_result.ToString();
                    Percent = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Minus = true;
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Multiple = true;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Devide = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            Plus = false;
            Minus = false;
            Multiple = false;
            Devide = false;
            Percent = false;
            Power = false;
            Root = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            Plus = false;
            Minus = false;
            Multiple = false;
            Devide = false;
            Percent = false;
            Power = false;
            Root = false;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Percent = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
            }
            catch (Exception)
            {
                textBox1.Text = "0";
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Power = true;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            Root = true;
            result1 = Convert.ToDouble(textBox1.Text);
            double my_result = Math.Sqrt(result1);
            textBox1.Text = my_result.ToString();
        }

        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void btntripleZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "000";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا  عدد وارد کنید!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.textBox1.Text = textBox1.Text;
            form.value += Convert.ToDouble(textBox1.Text);
            form.Show();
            //this.Hide();
            this.Close();
        }
    }
}
