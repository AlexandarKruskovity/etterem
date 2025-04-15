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

            int osszAr = Convert.ToInt32(label17.Text);

            if (pizza != null)
            {
                label13.Text = pizza ;
                label22.Text = Convert.ToString(osszAr);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string snackCsirke = "Snack Deal roppanós...";
            

            if (snackCsirke != null)
            {
                label14.Text = snackCsirke;
                label18.Text=label6.Text ;

                
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
