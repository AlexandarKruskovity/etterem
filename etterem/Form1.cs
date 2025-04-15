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
            string pizza = "Közepes méretű...";
            

            if (pizza != null)
            {
                label13.Text = pizza ;
                label17.Text=label5.Text ;
               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string snackCsirke = "Snack Deal roppanós...";
            int osszAR;
           
            if (snackCsirke != null)
            {
                label14.Text = snackCsirke;
                label18.Text=label6.Text ;
                label22.Text=label17.Text+label18.Text+label19.Text+label20.Text ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string snackHagyma = "Snack Deal Fokhagymás...";
            if (snackHagyma!=null)
            {
                label15.Text = snackHagyma;
                label19.Text=label7.Text ;

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Választott_főétel etel=new Választott_főétel();
            etel.ShowDialog();
        }

        
    }
}
