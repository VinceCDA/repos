using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Additionneur
{
    public partial class Form1 : Form
    {
        int r = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bouton_0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0+";
            
            
        }

        private void bouton_1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1+";
            r += 1;
            
        }

        private void bouton_2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2+";
            r += 2;
        }

        private void bouton_3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3+";
            r += 3;
        }

        private void bouton_4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4+";
            r += 4;
        }

        private void bouton_5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5+";
            r += 5;
        }

        private void bouton_6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6+";
            r += 6;
        }

        private void bouton_7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7+";
            r += 7;
        }

        private void bouton_8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8+";
            r += 8;
        }

        private void bouton_9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9+";
            r += 9;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            r = 0;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"{r}+";
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Fin de l'application.");
        }
    }
}
