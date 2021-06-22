using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipChara01
{
    public partial class Form1 : Form
    {
        string stringOut;
        public Form1()
        {
            
            InitializeComponent();
            
            
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            
            //txtSource.Enabled = false;
            //txtChain1.Enabled = false;
            //txtChain2.Enabled = false;
            if (addChain1.Checked)
            {
                if (string.IsNullOrEmpty(stringOut))
                {
                    stringOut = txtSource.Text + txtChain1.Text;
                    txtOut.Text = stringOut;
                }
                else
                {
                    
                    stringOut += txtChain1.Text;
                    txtOut.Text = stringOut;
                }
                
            }
            if (swapChain1byChain2.Checked)
            {
                stringOut = stringOut.Replace(txtChain1.Text, txtChain2.Text);
                txtOut.Text = stringOut;
            }
            if (swap1StChain1ByChain2.Checked)
            {
                try
                {
                    int i = stringOut.IndexOf(txtChain1.Text);
                    if (i!=-1)
                    {
                        errorProvider1.SetError(txtChain1, "");
                        stringOut = stringOut.Remove(i, txtChain1.Text.Length);
                        stringOut = stringOut.Insert(i, txtChain2.Text);
                        txtOut.Text = stringOut;
                    }
                    else
                    {
                        errorProvider1.SetError(txtChain1, "La valeur n'est pas présente");
                    }
                   
                }
                catch (Exception)
                {

                    txtOut.Text = "Impossible";
                }
                
            }
            if (swapLastChain1byChain2.Checked)
            {
                try
                {
                    int i = stringOut.LastIndexOf(txtChain1.Text);
                    stringOut = stringOut.Remove(i, txtChain1.Text.Length);
                    stringOut = stringOut.Insert(i, txtChain2.Text);
                    txtOut.Text = stringOut;
                }
                catch (Exception)
                {
                    txtOut.Text = "Impossible";
                    
                }
                
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) | string.IsNullOrEmpty(txtChain1.Text) | string.IsNullOrEmpty(txtChain2.Text))
            {
                finalButton.Enabled = false;
            }
            else
            {
                finalButton.Enabled = true;
            }
        }

        private void txtChain1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) | string.IsNullOrEmpty(txtChain1.Text) | string.IsNullOrEmpty(txtChain2.Text))
            {
                finalButton.Enabled = false;
            }
            else
            {
                finalButton.Enabled = true;
            }
        }

        private void txtChain2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) | string.IsNullOrEmpty(txtChain1.Text) | string.IsNullOrEmpty(txtChain2.Text))
            {
                finalButton.Enabled = false;
            }
            else
            {
                finalButton.Enabled = true;
            }
        }
    }
}
