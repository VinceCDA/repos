using System;
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
    public partial class FrmSalaries : Form
    {
        Salarie salarie;
        Salaries salaries;
        public FrmSalaries()
        {
            InitializeComponent();
        }

        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries )
            {
                cbSalaries.Items.Add(item.Matricule);
            }
        }

      
        private void ChargerSalarie()
        {
            salarie = salaries.ExtraireSalarie(cbSalaries.SelectedItem.ToString());
            txtMatricule.Text = salarie.Matricule;
            txtNom.Text = salarie.Nom;
            txtPrénom.Text = salarie.Prenom;
            txtSalaireBrut.Text = salarie.SalaireBrut.ToString();
            txtTauxCs.Text = salarie.TauxCS.ToString();
            txtDate.Text = salarie.DateNaissance.ToShortDateString();
            if (salarie is Commercial)
            {
                chkCommercial.Checked = true;
                var salarieTmp = (Commercial) salarie;
                txtChiffre.Text = salarieTmp.ChiffreAffaire.ToString();
                txtCommission.Text = salarieTmp.Commission.ToString();
                gpCommercial.Visible = true;
                
            }
            txtMatricule.Enabled = false;
            txtNom.Enabled = false;
            txtPrénom.Enabled = false;
            txtSalaireBrut.Enabled = false;
            txtTauxCs.Enabled = false;
            txtDate.Enabled = false;
            txtChiffre.Enabled = false;
            txtCommission.Enabled = false;

            
            
        }
        private void ClearBox()
        {
            txtMatricule.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrénom.Text = string.Empty;
            txtSalaireBrut.Text = string.Empty;
            txtTauxCs.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtChiffre.Text = string.Empty;
            txtCommission.Text = string.Empty;
            txtChiffre.Text = string.Empty;
            txtCommission.Text = string.Empty;
        }

        private void cbSalaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerSalarie();

        }

        private void txtMatricule_Validating(object sender, CancelEventArgs e)
        {
            if (Salarie.IsMatriculeValide(txtMatricule.Text))
            {

            }
            else
            {
                errorProvider1.SetError(txtMatricule, "Matricule non valide");
                e.Cancel = true;
            }
        }

        private void FrmSalaries_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = false;
        }

        private void supprimerSalarie_Click(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(txtMatricule.Text);
            salaries.Remove(salarie);
            cbSalaries.Items.Clear();
            foreach (Salarie item in salaries)
            {
                cbSalaries.Items.Add(item.Matricule);
            }
            ClearBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
