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

namespace Calculator
{
    public partial class Form1 : Form
    {

        private bool needsClearing = false;
        private double value = 0;
        private string lastSym = "+";

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "This is where your calculation will be displayed.";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 7 into your calculation.";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 9 into your calculation.";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 8 into your calculation.";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 4 into your calculation.";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 5 into your calculation.";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 6 into your calculation.";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 1 into your calculation.";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 2 into your calculation.";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 3 into your calculation.";
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button to enter a 0 into your calculation.";
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "This button will evaluate your calculation.";
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button for addition.";
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button for subtraction.";
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button for multiplication.";
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "Use this button for division.";
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Text = "This button will clear your calculation.";
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void digits(object sender, EventArgs e)
        {
            if (needsClearing)
            {
                this.textBox1.Text = "";
                needsClearing = false;
            }
            Button b = (Button) sender;
            this.textBox1.Text += b.Text;
            this.button15.Enabled = true;
            this.button14.Enabled = true;
            this.button13.Enabled = true;
            this.button12.Enabled = true;
            this.button11.Enabled = true;
        }

        private void operators(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            calc(this.textBox1.Text);
            lastSym = b.Text;
            //this.textBox1.Text += b.Text;
            this.button15.Enabled = false;
            this.button14.Enabled = false;
            this.button13.Enabled = false;
            this.button12.Enabled = false;
            this.button11.Enabled = false;
            needsClearing = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            needsClearing = false;
            value = 0;
            lastSym = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc(this.textBox1.Text);
            this.textBox1.Text = value.ToString();
            value = 0;
            lastSym = "+";
            needsClearing = true;
        }

        private double calc(String s)
        {
            if (lastSym == "+")
            {
                value += Int32.Parse(this.textBox1.Text);
            }
            else if (lastSym == "x")
            {
                value *= Int32.Parse(this.textBox1.Text);
            }
            else if (lastSym == "-")
            {
                value -= Int32.Parse(this.textBox1.Text);
            }
            else if (lastSym == "/")
            {
                value /= Int32.Parse(this.textBox1.Text);
            }
            return value;
        }
    }
}
