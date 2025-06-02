using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etterem
{
    public partial class Form1 : Form
    {
        public int teljesAr = 0;
        public Timer timer=new Timer();

        public Form1()
        {
            InitializeComponent();
            
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string pizza = "Közepes méretű mézes-csípős-olasz...";
           
            


            if (pizza != null)
            {
                label13.Text = pizza ;
                label17.Text = "3845";
                teljesAr += Convert.ToInt32(label17.Text);
                label23.Text = teljesAr.ToString();
                timer.Enabled = true;

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string snackCsirke = "Snack Deal roppanós...";
            

            if (snackCsirke != null)
            {
                label14.Text = snackCsirke;
                label18.Text="1245" ;
                teljesAr += Convert.ToInt32(label18.Text);
                label23.Text = teljesAr.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string snackHagyma = "Snack Deal Fokhagymás...";
            if (snackHagyma!=null)
            {
                label16.Text = snackHagyma;
                label19.Text ="1045";
                teljesAr += Convert.ToInt32(label19.Text);
                label23.Text = teljesAr.ToString();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Választott_főétel etel=new Választott_főétel();
            etel.ShowDialog();
            label20.Text = Convert.ToString(Választott_főétel.ossz);
            teljesAr += Convert.ToInt32(label20.Text);
            label23.Text = teljesAr.ToString();

            label15.Text = Választott_főétel.rizs + " " + Választott_főétel.sali;
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label17.Text == " " && label18.Text==" "&& label19.Text==" "&& label20.Text==" ")
            {
                MessageBox.Show("A kosár üres nem tudsz fizetni");
            }
            else
            {

                MessageBox.Show("Rendelésed sikeres!Átveheted éttermünkbrn:)");
            }
            
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label17.Text = " ";
            label18.Text = " "; 
            label19.Text = " "; 
            label20.Text = " ";
            label23.Text=" ";
            teljesAr = 0;
          
        }
    }
}
