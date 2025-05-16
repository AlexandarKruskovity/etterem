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
        public static string ossz = "1995" ;
        public static string rizs = "A választott köret:Rízs" ;
        public static string sali = "A választott főétel:Zöld saláta" ;
       
        public Választott_főétel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string teszta = $"A választott főétel:{label3.Text}";
            label13.Text = teszta;
            label16.Text = label8.Text;

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
            label16.Text = label8.Text;
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
            label16.Text = label8.Text;
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
            label16.Text = label8.Text;
            if (checkBox4.Checked) 
            {
                rizs = "A választott köret: Sült burgonya";
            }
            else
            {
                rizs = " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string koret = $"A választott köret:{label14.Text}";
            label15.Text = koret;
            label16.Text = label8.Text;
            if (checkBox5.Checked)
            {
                rizs = "A választorr köret: Rizs";
            }
            else
            {
                rizs = " ";
            }
        } 
    }
}
