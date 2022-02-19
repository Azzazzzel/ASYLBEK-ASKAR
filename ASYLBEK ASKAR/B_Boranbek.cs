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
    public partial class B_Boranbek : Form
    {
        int LPW;

        bool Hided;
        public B_Boranbek()
        {
            InitializeComponent();
            LPW = panel1.Width;
            
            Hided = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hided) button2.Text = "<";
            else button2.Text = ">";
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                button2.Visible = false;
                panel1.Width = panel1.Width + 40;
                if (panel1.Width >= 280)
                {
                    timer1.Stop();
                    button2.Visible = true;
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 40;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            etB0919_11.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
        }
    }
}
