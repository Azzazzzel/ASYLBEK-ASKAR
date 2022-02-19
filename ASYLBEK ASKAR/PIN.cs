using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASYLBEK_ASKAR
{
    public partial class PIN : Form
    {
        public PIN()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
                textBox1.Text =textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2004")
            {
                this.Hide();
                FormAdmin fA = new FormAdmin();
                fA.Show();
            }
        }

        

       

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 3)
            {
                Button B = (Button)sender;
                textBox1.Text = textBox1.Text + B.Text;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
