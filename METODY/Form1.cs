using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METODY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //METODA03
        double vzdalenost(double a1, double a2, double b1, double b2)
        {
            return Math.Sqrt((a1 - b1) * (a1 - b1) + (a2 - b2) * (a2 - b2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //METODA03
            int a1 = Convert.ToInt32(textBox1.Text), a2 = Convert.ToInt32(textBox2.Text), b1 = Convert.ToInt32(textBox3.Text), b2 = Convert.ToInt32(textBox4.Text);
            MessageBox.Show("Vzdalenost je: " + vzdalenost(a1, a2, b1, b2).ToString());
        }
    }
}
