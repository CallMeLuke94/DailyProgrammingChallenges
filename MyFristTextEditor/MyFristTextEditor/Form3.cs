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
    public partial class Form3 : Form
    {
        Form1 mainForm;

        public Form3(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.richTextBox1.LoadFile(this.textBox1.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                this.textBox1.Text = "You need to type the name of a real file!";
            }
        }
    }
}
