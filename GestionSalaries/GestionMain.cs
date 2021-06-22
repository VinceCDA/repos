﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class GestionMain : Form
    {
        public GestionMain()
        {
            InitializeComponent();
        }

        private void gestionUtilistateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs formUtilisteur = new FrmUtilisateurs();
            formUtilisteur.MdiParent = this;
            formUtilisteur.Show();
        }

        private void gestionSalariésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalaries formSalarie = new FrmSalaries();
            formSalarie.MdiParent = this;
            formSalarie.Show();
        }
    }
}
