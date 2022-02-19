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
    public partial class ETB0919OBBbaga : Form
    {
        bool Hided1;
        bool Hided2;
        public ETB0919OBBbaga()
        {
            InitializeComponent();
            Hided2 = true;
            Hided1 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (Hided1) LogBtn.Text = "ТҮСІРУ";
            else LogBtn.Text = "КӨТЕРУ";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided1)
            {
                panel7.Height = panel7.Height + 50;
                if (panel7.Height >= 414)
                {
                    timer1.Stop();
                    Hided1 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel7.Height = panel7.Height - 50;
                if (panel7.Height <= 0)
                {
                    timer1.Stop();
                    Hided1 = true;
                    this.Refresh();
                }
            }
        }

        private void ETB0919OBBbaga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet._ETB0919_1OBEKT". При необходимости она может быть перемещена или удалена.
            this.eTB0919_1OBEKTTableAdapter.Fill(this.database1DataSet._ETB0919_1OBEKT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView1.Refresh();
            dataGridView1.RefreshEdit();
            dataGridView1.Show();
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
    }
}
