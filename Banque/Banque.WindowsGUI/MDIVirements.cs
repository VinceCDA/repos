using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banque.WindowsGUI
{
    public partial class MDIVirements : Form
    {
        private int childFormNumber = 1;

        public MDIVirements()
        {
            InitializeComponent();
        }

        private void NouveauVirement(object sender, EventArgs e)
        {
            // Affichage de la fenêtre de création d'un nouveau virement
            CreationVirement();
        }
        /// <summary>
        /// Gestion des virements en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionVirement(object sender, EventArgs e)
        {

        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Lors du premier affichage de la fenêtre MDI
        /// Chargement du formulaire de connexion
        /// Si connexion OK, affichage de la fenêtre de création d'un nouveau virement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MDIVirements_Shown(object sender, EventArgs e)
        {
            FrmConnexion oConnexion = new FrmConnexion();
            oConnexion.WindowState = FormWindowState.Normal;
            DialogResult oResult = oConnexion.ShowDialog();
            if (oResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else if (oResult == DialogResult.OK)
            {
                // Affichage de la fenêtre de création d'un nouveau virement
                CreationVirement();
            }
        }
        /// <summary>
        /// Affichage du formulaire de création d'un nouveau virement
        /// </summary>
        private void CreationVirement()
        {
            FrmVirement childForm = new FrmVirement();
            childForm.MdiParent = this;
            childForm.Text = string.Format("{0} {1}", childForm.Text, childFormNumber++);
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }





    }
}
