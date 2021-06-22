using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choixCasse_Enter(object sender, EventArgs e)
        {

        }

        private void choix_Enter(object sender, EventArgs e)
        {
            if (txtSource.TextLength != 0)
            {
                choix.Enabled = true;
            }
            else
            {
                choix.Enabled = false;
            }
            txtOut.Text = txtSource.Text;
        }

        private void couleurFondBox_CheckedChanged(object sender, EventArgs e)
        {
            if (couleurFondBox.Checked)
            {
                choixFond.Visible = true;
            }
            else
            {
                choixFond.Visible = false;
            }

        }

        private void couleurCaracBox_CheckedChanged(object sender, EventArgs e)
        {
            if (couleurCaracBox.Checked)
            {
                choixCarac.Visible = true;
            }
            else
            {
                choixCarac.Visible = false;
            }
        }

        private void casseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (casseBox.Checked)
            {
                choixCasse.Visible = true;
            }
            else
            {
                choixCasse.Visible = false;
            }
        }

        private void fondRougeBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.BackColor = Color.Red;
            fondRougeBouton.Checked = false;
            couleurFondBox.Checked = false;

        }

        private void fondVertBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.BackColor = Color.Green;
            fondVertBouton.Checked = false;
            couleurFondBox.Checked = false;
        }

        private void fondBleuBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.BackColor = Color.Blue;
            fondBleuBouton.Checked = false;
            couleurFondBox.Checked = false;
        }

        private void caracRougeBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.ForeColor = Color.Red;
            caracRougeBouton.Checked = false;
            couleurCaracBox.Checked = false;
        }

        private void caracBlancBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.ForeColor = Color.White;
            caracBlancBouton.Checked = false;
            couleurCaracBox.Checked = false;
        }

        private void caracNoirBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.ForeColor = Color.Black;
            caracNoirBouton.Checked = false;
            couleurCaracBox.Checked = false;
        }

        private void miniBouton_CheckedChanged(object sender, EventArgs e)
        {
            
            txtOut.Text = txtSource.Text.ToLower();
            miniBouton.Checked = false;
            casseBox.Checked = false;
        }

        private void majBouton_CheckedChanged(object sender, EventArgs e)
        {
            txtOut.Text = txtSource.Text.ToUpper();
            miniBouton.Checked = false;
            casseBox.Checked = false;
        }
    }
}
