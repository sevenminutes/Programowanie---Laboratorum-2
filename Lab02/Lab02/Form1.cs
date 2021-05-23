using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (standard.Checked)
            {
                ideal.Enabled = false;
            }
            else
            {
                ideal.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wynik1;
            double.TryParse(textBox1.Text, out wynik1);


            if (standard.Checked)
            {
                wynik1 -= 100;
                Wynik.Text = wynik1.ToString();
            }
            if (ideal.Checked)
            {
                double wynik2;
                wynik1 -= 100;

                if (radiom.Checked)
                {
                    wynik2 = wynik1 * 0.9;
                    Wynik.Text = wynik2.ToString();
                }
                if (radiok.Checked)
                {
                    wynik2 = wynik1 * 0.85;
                    Wynik.Text = wynik2.ToString();
                }
            }




        }
        private void textBox1_Text(object sender, EventArgs e)
        {
         
        }

        private void ideal_CheckedChanged(object sender, EventArgs e)
        {
            if (ideal.Checked)
            {
                standard.Enabled = false;
            }
            else
            {
                standard.Enabled = true;
            }
        }
    }
}
