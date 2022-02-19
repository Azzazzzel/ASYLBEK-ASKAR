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
    public partial class Form1 : Form
    {
        int LPW;
        int RPW;
        int BPH;
        bool Hided;
        bool Hided1;
        bool Hided2;
       
        public Form1()
        { 
            InitializeComponent();
            panel4.Visible = false;
            panel5.Visible = false;
            LPW = panel1.Width;
            RPW = KolledzhGroups.Width;
            BPH = panel7.Height;
            Hided = true;
            Hided1 = true;
            Hided2 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hided) button2.Text = "<";
            else button2.Text = ">";
            timer1.Start();
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                button2.Visible = false; 
                panel1.Width = panel1.Width + 40;
                if (panel1.Width >= LPW)
                {
                    timer1.Stop();
                    button2.Visible=true;
                    Hided = false;
                    this.Refresh();
                }
            }
            else { 
            panel1.Width=panel1.Width - 40;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    Hided=true;
                    this.Refresh();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            panel1.Width = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PIN pin = new PIN();
            pin.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hided1)
            {
                panel7.Height = panel7.Height + 50;
                if (panel7.Height >= 414)
                {
                    timer2.Stop();
                    Hided1 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel7.Height = panel7.Height - 50;
                if (panel7.Height <= 0)
                {
                    timer2.Stop();
                    Hided1 = true;
                    this.Refresh();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         


            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "S_Sabira";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
          
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "A_Aizhan";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start(); 
            textBox1.Text = "E_Pernebek";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "Zh_Moldir";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "D_Fariza";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "K_Aigerim";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "X_Akerke";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "T_Erbolat";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer2.Start();
            textBox1.Text = "B_Boranbek";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "S_Sabira" && textBox2.Text == "User2021@")

            {
               
            }
            else if (textBox1.Text == "A_Aizhan" && textBox2.Text == "User2021@")
            {
                this.Hide();
                A_Aizhan Aa = new A_Aizhan();
                Aa.Show();
            }
            else if (textBox1.Text == "E_Pernebek" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "Zh_Moldir" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "D_Fariza" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "K_Aigerim" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "X_Akerke" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "T_Erbolat" && textBox2.Text == "User2021@")
            {

            }
            else if (textBox1.Text == "B_Boranbek" && textBox2.Text == "User2021@")
            {
                this.Hide();
                B_Boranbek Bb = new B_Boranbek();
                Bb.Show();
            }
            else
            {
                MessageBox.Show("ЛОГИН МЕН ҚҰПИЯСӨЗДІҢ ДҰРЫСТЫҒЫН ТЕКСЕРІҢІЗ\n\tнемесе\nСІЗ ЖҮЙЕГЕ ТІРКЕЛМЕГЕНСІЗ");
            }
        }

      

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
            }
            else { panel4.Visible = false;
                panel5.Visible = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Hided2) button19.Text = ">";
            else button19.Text = "<";
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Hided2)
            {
                button19.Visible = false;
                KolledzhGroups.Width = KolledzhGroups.Width + 40;
                if (KolledzhGroups.Width >= 200)
                {
                    timer3.Stop();
                    button19.Visible = true;
                    Hided2 = false;
                    this.Refresh();
                }
            }
            else
            {
                KolledzhGroups.Width = KolledzhGroups.Width - 40;
                if (KolledzhGroups.Width <= 0)
                {
                    timer3.Stop();
                    Hided2 = true;
                    this.Refresh();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ETB0919OBBbaga eTB0919OBBbaga = new ETB0919OBBbaga();
            eTB0919OBBbaga.Show();
        }
    }
}
