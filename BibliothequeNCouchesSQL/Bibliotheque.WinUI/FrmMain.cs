using Bibliotheque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque.WinUI
{
    public partial class FrmMain : Form
    {
        DB dbBiblio = new DB();
        public FrmMain()
        {
            
            InitializeComponent();
        }


        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void choixDuSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bibliothequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            dbBiblio.GetDBConnection();
            
        }

        private void pretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pret = new FormPret();
            pret.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form TestDataBind = new TestDataBind();
            TestDataBind.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form testenfant = new TestEnfants();
            testenfant.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form ajoutAdherent = new AjoutAdherent();
            ajoutAdherent.Show();
        }
    }
}
