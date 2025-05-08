using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etterem
{
    public partial class Választott_főétel : Form
    {
        public static string ossz = "1995.00 Ft" ;
        public static string rizs = "A választott köret:Rízs" ;
        public static string sali = "A választott főétel:Zöld saláta" ;
       
        public Választott_főétel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            label17.Text = Convert.ToString(ossz);
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string teszta = $"A választott főétel:{label3.Text}";
            label13.Text = teszta;
            label17.Text = label8.Text;

            if (checkBox1.Checked)
            {
                sali = "A választott főétel: Sült tészta";
            }
            else
            {
                sali = " ";
            }
               

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string teszta = $"A választott főétel:{label4.Text}";
            label13.Text = teszta;
            label17.Text = label8.Text;
            if (checkBox2.Checked)
            {
                sali = "A választott főétel: Zöld saláta";
            }
            else
            {
                sali = " ";
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

            string teszta = $"A választott főétel:{label5.Text}";
            label13.Text = teszta;
            label19.Text = label8.Text;
            if (checkBox3.Checked)
            {
                sali = "A választott főétel: Melst";
            }
            else
            {
                sali = " ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string koret = $"A választott köret:{label7.Text}";
            label15.Text = koret;
            label17.Text = label8.Text;
            if (koret == label14.Text)
            {
                rizs = label7.Text;
            }
            else
            {
                rizs = "A választott köret:Sült burgonya";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string koret = $"A választott köret:{label14.Text}";
            label15.Text = koret;
            label17.Text = label8.Text;
           

        }

        
      
    }
}
