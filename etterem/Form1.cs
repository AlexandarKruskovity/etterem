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
        public Form1()
        {
            InitializeComponent();
            
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string pizza = "Közepes méretű mézes-csípős-olasz...";
            int osszar = 0;
            


            if (pizza != null)
            {
                label13.Text = pizza ;
               label17.Text=label5.Text ;
                osszar=Convert.ToInt32(label17.Text) ;
                label23.Text=osszar.ToString();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string snackCsirke = "Snack Deal roppanós...";
            

            if (snackCsirke != null)
            {
                label14.Text = snackCsirke;
                label18.Text=label6.Text ;
                 ;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string snackHagyma = "Snack Deal Fokhagymás...";
            if (snackHagyma!=null)
            {
                label16.Text = snackHagyma;
                label19.Text = label7.Text;


            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Választott_főétel etel=new Választott_főétel();
            etel.ShowDialog();
            label20.Text = Convert.ToString(Választott_főétel.ossz);


            label15.Text = Választott_főétel.rizs + " " + Választott_főétel.sali;
            
            
        }

      
    }
}
