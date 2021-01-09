using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace total
{
    public partial class Form1 : Form
    {
        decimal num1, num2, num3;
        string op = "";
        bool isoparand = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && op == "/")
            {
                MessageBox.Show("ไม่สามารถหารด้วย 0 ได้");
                return;
            }
            switch (op)
            {
                case "+":
                    num3 = num1 + Decimal.Parse(textBox1.Text);
                    break;
                case "-":
                    num3 = num1 - Decimal.Parse(textBox1.Text);
                    break;
                case "*":
                    num3 = num1 * Decimal.Parse(textBox1.Text);
                    break;
                case "/":
                    num3 = num1 / Decimal.Parse(textBox1.Text);
                    break;
            }
            num1 = num3;
            isoparand = true;
            textBox1.Text = num3.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isoparand)
            {
                textBox1.Text = "";
                isoparand = false;
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            op = "";
            isoparand = false;
            num1 = num2 = num3 = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("เลิกกดได้แล้วอีควัย");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text.Length > 0)
                {
                    if (op == "" || op == "=")
                    {
                        label1.Text += textBox1.Text + " + ";
                        num1 = Decimal.Parse(textBox1.Text);
                        op = "+";
                        isoparand = true;
                    }
                    else
                    {
                        label1.Text += textBox1.Text + " + ";
                        this.Calculate();
                        op = "+";
                    }
                }
            }
        

        private void Calculate()
            {
                //     true  && true  = true
                //     true  && false = false
                //     false && false = false

                //     true  || true  = true
                //     true  || false = true
                //     false || false = false

                //     !true = false
                //     !false = true
                if (textBox1.Text == "0" && op == "/")
                {
                    MessageBox.Show("ไม่สามารถหารด้วย 0 ได้");
                    return;
                }
                switch (op)
                {
                    case "+":
                        num3 = num1 + Decimal.Parse(textBox1.Text);
                        break;
                    case "-":
                        num3 = num1 - Decimal.Parse(textBox1.Text);
                        break;
                    case "*":
                        num3 = num1 * Decimal.Parse(textBox1.Text);
                        break;
                    case "/":
                        num3 = num1 / Decimal.Parse(textBox1.Text);
                        break;
                }
            num1 = num3;
            isoparand = true;
            textBox1.Text = num3.ToString();
        } 
        
        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                if (op == "" || op == "=")
                {
                    label1.Text += textBox1.Text + " - ";
                    num1 = Decimal.Parse(textBox1.Text);
                    op = "-";
                    isoparand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " -  ";
                    this.Calculate();
                    op = "-";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                if (op == "" || op == "=")
                {
                    label1.Text += textBox1.Text + " *  ";
                    num1 = Decimal.Parse(textBox1.Text);
                    op = "*";
                    isoparand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " *  ";
                    this.Calculate();
                    op = "*";
                }
            }
        }

            private void button18_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                if (op == "" || op == "=")
                {
                    label1.Text += textBox1.Text + " ÷  ";
                    num1 = Decimal.Parse(textBox1.Text);
                    op = "/";
                    isoparand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " ÷  ";
                    this.Calculate();
                    op = "/";
                }
            }
        }
    }
}
