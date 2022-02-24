using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string w = textBox1.Text.ToString();
            int len = w.Length;
            if (textBox1.Text[--len] != '.')
            {
                textBox1.Text += ".";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(textBox1.Text));
                textBox1.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(textBox1.Text), 2);
                textBox1.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(textBox1.Text, "");
                textBox1.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }
    }
}
