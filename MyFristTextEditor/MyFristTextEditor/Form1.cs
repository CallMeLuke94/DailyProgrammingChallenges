using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyFristTextEditor
{
    public partial class Form1 : Form
    {
        private bool changed = false;
        private string file_name = "";
        private bool cancelClose = false;
        private string star = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void form1_resize(object sender, EventArgs e)
        {
            this.richTextBox1.Width = this.Width - 38;
            this.richTextBox1.Height = this.Height - 90;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //actually new
        {
            if (changed)
            {
                DialogResult result1;
                result1 = MessageBox.Show("Do you wish to create a new file without saving?", "New",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result1 == DialogResult.Yes)
                {
                    this.richTextBox1.Text = "";
                    changed = false;
                    star = "";
                    this.Text = "New File";
                }
                else if (result1 == DialogResult.No)
                    saveToolStripMenuItem_Click(sender, e);
            }
            else
            {
                this.richTextBox1.Text = "";
                changed = false;
                star = "";
                this.Text = "New File";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file_name == "" || changed)
            {
                save1.ShowDialog();
                file_name = save1.FileName;
            }
            try
            {
                this.richTextBox1.SaveFile(file_name);
                changed = false;
                star = "";
            }
            catch
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) //actually open
        {
            if (changed)
            {
                DialogResult result1;
                result1 = MessageBox.Show("Do you wish to open a new file without saving?", "Open",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result1 == DialogResult.Yes)
                {
                    open1.ShowDialog();
                    try
                    {
                        this.richTextBox1.LoadFile(open1.FileName);
                        file_name = open1.FileName;
                        FileInfo f = new FileInfo(file_name);
                        this.Text = f.Name;
                        changed = false;
                        star = "";
                    }
                    catch
                    {

                    }
                }
                else if (result1 == DialogResult.No)
                    saveToolStripMenuItem_Click(sender, e);
            }
            else
            {
                open1.ShowDialog();
                try
                {
                    this.richTextBox1.LoadFile(open1.FileName);
                    file_name = open1.FileName;
                    FileInfo f = new FileInfo(file_name);
                    this.Text = f.Name;
                    changed = false;
                    star = "";
                }
                catch
                {

                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                DialogResult result1;
                result1 = MessageBox.Show("Do you wish to close without saving?", "Close",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result1 == DialogResult.Yes)
                {
                    changed = false;
                    star = "";
                    Application.Exit();
                }
                else if (result1 == DialogResult.No)
                    saveToolStripMenuItem_Click(sender, e);
                else
                    cancelClose = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            changed = true;
            if (star == "")
            {
                star = "*";
                this.Text += star;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.richTextBox1.Font = fontDialog1.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeToolStripMenuItem_Click(sender, e);
            if (cancelClose)
                e.Cancel = true;
        }
    }
}
