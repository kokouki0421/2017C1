using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* double x = double.Parse(textBox1.Text);
             double y = double.Parse(textBox2.Text);
             label1.Text = (x + y).ToString();*/
            input(1);
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            /*double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            label1.Text = (x - y).ToString();*/
            input(1);
        }
        private void input(int i)
        {
            double x = double.Parse(textBox3.Text);
            double y = double.Parse(textBox4.Text);
            if (i==1)
            {
                label2.Text = (x + y).ToString(); 
            }
            else if(i==2)
            {
                label2.Text = (x - y).ToString();
            }
            else if(i==3)
            {
                label2.Text = (x * y).ToString();
            }
            else
            {
                label2.Text = (x / y).ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            input(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input(5);
        }

        private void button_Click1(object sender, EventArgs e)
        {
            input(1);
        }
    }
}
