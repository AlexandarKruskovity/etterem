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
    public partial class Választott_főétel : Form
    {
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
            string teszta =  $"A választott főétel:{label3.Text}";
            label13.Text=teszta;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string teszta = $"A választott főétel:{label4.Text}";
            label13.Text = teszta;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string teszta = $"A választott főétel:{label5.Text}";
            label13.Text = teszta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string koret = $"A választott köret:{label7.Text}";
            label15.Text = koret;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string koret = $"A választott köret:{label14.Text}";
            label15.Text = koret;
        }
    }
}
