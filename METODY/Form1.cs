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
        //METODA04
        double mocnina(double a, double b)
        {
            double vysledek = 1;
            if (b > 0)
            {
                int i = 0;
                while (i < b)
                {
                    vysledek *= a;
                    ++i;
                }
            }
            else if (b < 0)
            {
                int i = 0;
                while (i > b)
                {
                    vysledek /= a;
                    --i;
                }
            }

            return vysledek;
        }
        //METODA5
        double faktorial(double q)
        {
            double vysledek = 1;
            while (q > 0)
            {
                vysledek *= q;
                q--;
            }
            return vysledek;
        }
        //METODA6
        int cifLichSoucet(int p)
        {
            int soucet = 0;
            while (p > 0)
            {
                if ((p % 10) % 2 != 0) soucet += p % 10;
                p /= 10;
            }
            return soucet;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //METODA03
            int a1 = Convert.ToInt32(textBox1.Text), a2 = Convert.ToInt32(textBox2.Text), b1 = Convert.ToInt32(textBox3.Text), b2 = Convert.ToInt32(textBox4.Text);
            MessageBox.Show("Vzdalenost je: " + vzdalenost(a1, a2, b1, b2).ToString());
            //METODA04
            int a = Convert.ToInt32(textBox5.Text);
            int b = Convert.ToInt32(textBox6.Text);
            MessageBox.Show("Mocnina je: " + mocnina(a, b).ToString());
            //METODA5
            double q = Convert.ToDouble(textBox7.Text);
            label4.Text = faktorial(q).ToString();
            //METODA06
            int p = Convert.ToInt32(textBox8.Text);
            label6.Text = cifLichSoucet(a).ToString();
        }
    }
}
