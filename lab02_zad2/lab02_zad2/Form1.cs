using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zmiana = textBox1.Text;
            if (wmala.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 4);
                textBox1.Text = zmiana;
            }
            if (wduza.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 8);
                textBox1.Text = zmiana;
            }
            if (wbduza.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 12);
                textBox1.Text = zmiana;
            }
            if (pog.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
                textBox1.Text = zmiana;
            }
            if (poch.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
                textBox1.Text = zmiana; 
            }
            if (pod.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
                textBox1.Text = zmiana;
            }
            if (czer.Checked)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = zmiana;
            }
            if (nieb.Checked)
            {
                textBox1.ForeColor = Color.Blue ;
                textBox1.Text = zmiana;
            }
            if (pom.Checked)
            {
                textBox1.ForeColor = Color.Orange;
                textBox1.Text = zmiana;
            }
        }
    }
}
