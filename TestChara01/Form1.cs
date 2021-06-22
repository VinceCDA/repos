using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestChara01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void ansButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (char.IsLetter(txtSource.Text[(int)posiChara.Value])) txtOut.Text = "Ceci est une lettre.";
                else if (char.IsNumber(txtSource.Text[(int)posiChara.Value])) txtOut.Text = "Ceci est un nombre.";
                else if (char.IsPunctuation(txtSource.Text[(int)posiChara.Value])) txtOut.Text = "Ceci est une ponctuation.";
                else if (char.IsSymbol(txtSource.Text[(int)posiChara.Value])) txtOut.Text = "Ceci est un symbole.";
                else if (char.IsSeparator(txtSource.Text[(int)posiChara.Value])) txtOut.Text = "Ceci est un separateur.";
                else txtOut.Text = "??????";

            }
            catch (Exception)
            {
                txtOut.Text = "null";
                
            }
            //catch (IndexOutOfRangeException)
            //{
            //    txtOut.Text = "null";
                
            //}
            

            

        }
    }
}
