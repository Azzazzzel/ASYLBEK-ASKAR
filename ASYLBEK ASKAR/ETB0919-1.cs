using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ASYLBEK_ASKAR
{

    public partial class ETB0919_1ВЕБ : UserControl
    {
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\source\repos\ASYLBEK ASKAR\ASYLBEK ASKAR\Database1.mdf; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            //1 Абдукаримова Назима
            if (radio1Button2.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=1", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio1Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=1", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio1Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=1", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio1Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=1", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //2 Асылбек Асқар
            if (radio2Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=2", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio2Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=2", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio2Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=2", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio2Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=2", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //3 Асқар Нариман
            if (radio3Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=3", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio3Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=3", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio3Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=3", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio3Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=3", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //4 Әбен Мейірланбек
            if (radio4Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=4", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio4Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=4", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio4Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=4", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio4Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=4", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //5 Әбуталип Абзал
            if (radio5Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=5", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio5Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=5", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio5Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=5", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio5Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=5", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //6 Әлмахан Нұртөре
            if (radio6Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=6", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio6Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=6", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio6Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=6", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio6Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=6", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //7 Әнуар Асқар
            if (radio7Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=7", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio7Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=7", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio7Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=7", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio7Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=7", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }




            //8
            if (radio8Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=8", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio8Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=8", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio8Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=8", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio8Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=8", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //9
            if (radio9Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=9", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio9Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=9", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio9Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=9", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio9Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=9", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //10
            if (radio10Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=10", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio10Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=10", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio10Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=10", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio10Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=10", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //11
            if (radio11Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=11", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio11Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=11", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio11Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=11", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio11Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=11", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //12
            if (radio12Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=12", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio12Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=12", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio12Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=12", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio12Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=12", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //13
            if (radio13Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=13", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio13Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=13", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio13Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=13", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio13Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=13", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


            //14
            if (radio14Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=14", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio14Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=14", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio14Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=14", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio14Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=14", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



            //15

            if (radio15Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=15", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio15Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=15", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio15Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=15", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio15Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=15", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //16
            if (radio16Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=16", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio16Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=16", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio16Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=16", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio16Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=16", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //17
            if (radio17Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=17", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio17Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=17", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio17Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=17", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio17Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=17", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //18
            if (radio18Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=18", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio18Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=18", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio18Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=18", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio18Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=18", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //19
            if (radio19Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=19", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio19Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=19", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio19Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=19", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio19Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=19", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //20
            if (radio20Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=20", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio20Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=20", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio20Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=20", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio20Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=20", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //21
            if (radio21Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=21", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio21Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=21", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio21Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=21", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio21Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=21", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //22
            if (radio22Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=22", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio22Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=22", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio22Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=22", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio22Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=22", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //23
            if (radio23Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=23", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio23Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=23", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio23Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=23", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio23Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=23", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //24
            if (radio24Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=24", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio24Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=24", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio24Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=24", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio24Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=24", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //25
            if (radio25Button2.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=2  WHERE id=25", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio25Button3.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=3  WHERE id=25", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio25Button4.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=4  WHERE id=25", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radio25Button5.Checked == true)
            {
                con.Open();
                cmd = new SqlCommand(@"update  [ETB0919-1] set price=5  WHERE id=25", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



            MessageBox.Show("Сәтті өзгерді");

        }

        public ETB0919_1ВЕБ()
        {
            InitializeComponent();
            
        }

        private  void ETB0919_1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\user\source\repos\ASYLBEK ASKAR\ASYLBEK ASKAR\Database1.mdf;Integrated Security=True");
        }

       
    
    }
}
