using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFristTextEditor
{
    public partial class Form2 : Form
    {

        private Form1 mainForm;

        public Form2(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.richTextBox1.Text = replace(mainForm.richTextBox1.Text, this.textBox1.Text, this.textBox2.Text);
            this.Close();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {

        }

        private string replace(string fullText, string oldValue, string newValue)
        {
            string result = "";
            char[] allChars = fullText.ToCharArray();

            for(int i = 0; i < allChars.Length; i++)
            {
                string test = "";

                if (i < allChars.Length - oldValue.Length + 1)
                {
                    for (int j = 0; j < oldValue.Length; j++)
                    {
                        test += allChars[i + j];
                    }
                }

                if (test != oldValue)
                    result += allChars[i].ToString();
                else
                {
                    result += newValue;
                    i += oldValue.Length - 1;
                }
            }

            if (result == "")
                return fullText;
            else
                return result;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.replaceButton = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != null && this.textBox1.Text != null)
                this.button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != null && this.textBox1.Text != null)
                this.button1.Enabled = true;
        }
    }
}
