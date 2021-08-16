using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoDLL;

namespace JeuWinForms
{
    public partial class Main : Form
    {
        
        public Main()
        {
            

            InitializeComponent();
            
        }
        public HighScore HighScore;
        public List<HighScore> ListScore;

        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherPartie();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOptions frmOptions = new FrmOptions();
            if (frmOptions.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Main_Shown(object sender, EventArgs e)
        {
          //  AfficherPartie();
        }
        private void AfficherPartie()
        {
            FrmJeu frmJeu = new FrmJeu();
            frmJeu.Show();
        }
        /// <summary>
        /// Sur fermeture du formulaire principal MDI
        /// Sauvergarde des paramètres de l'application
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHighScore frmHighScore = new FrmHighScore();
            frmHighScore.Show();
        }
    }
}
