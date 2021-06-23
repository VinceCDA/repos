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

        enum Etat
        {
            Consultation = 0,
            Modification = 1
        }
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
            
            txtMatricule.Text = salarie.Matricule;
            txtNom.Text = salarie.Nom;
            txtPrénom.Text = salarie.Prenom;
            txtSalaireBrut.Text = salarie.SalaireBrut.ToString();
            txtTauxCs.Text = salarie.TauxCS.ToString();
            txtDate.Text = salarie.DateNaissance.ToShortDateString();
            if (salarie is Commercial commercial)
            {
                chkCommercial.Checked = true;
                //var salarieTmp = (Commercial) salarie;
                //txtChiffre.Text = salarieTmp.ChiffreAffaire.ToString();
                //txtCommission.Text = salarieTmp.Commission.ToString();
                txtChiffre.Text = commercial.ChiffreAffaire.ToString();
                txtCommission.Text = commercial.Commission.ToString();
                
            }
            else
            {
                chkCommercial.Checked = false;
            }
            GestionBox(Etat.Consultation);

            
            
        }
        private void RefresBox()
        {
            cbSalaries.Items.Clear();
            foreach (Salarie item in salaries)
            {
                cbSalaries.Items.Add(item.Matricule);
            }
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
        private void GestionBox(Etat etat)
        {
            switch (etat)
            {
                case Etat.Consultation:
                    txtMatricule.Enabled = false;
                    txtNom.Enabled = false;
                    txtPrénom.Enabled = false;
                    txtSalaireBrut.Enabled = false;
                    txtTauxCs.Enabled = false;
                    txtDate.Enabled = false;
                    txtChiffre.Enabled = false;
                    txtCommission.Enabled = false;
                    chkCommercial.Enabled = false;
                    break;
                case Etat.Modification:
                    txtMatricule.Enabled = true;
                    txtNom.Enabled = true;
                    txtPrénom.Enabled = true;
                    txtSalaireBrut.Enabled = true;
                    txtTauxCs.Enabled = true;
                    txtDate.Enabled = true;
                    txtChiffre.Enabled = true;
                    txtCommission.Enabled = true;
                    chkCommercial.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cbSalaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cbSalaries.SelectedItem.ToString());
            ChargerSalarie();

        }

        private void txtMatricule_Validating(object sender, CancelEventArgs e)
        {

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
            RefresBox();
            ClearBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifierSalarie_Click(object sender, EventArgs e)
        {
            GestionBox(Etat.Modification);
        }

        private void valdierSalarie_Click(object sender, EventArgs e)
        {
            decimal parseTauxCs = 0;
            decimal parseSalaire = 0;
            decimal.TryParse(txtTauxCs.Text,out parseTauxCs);
            if (!Salarie.IsMatriculeValide(txtMatricule.Text)) errorProvider1.SetError(txtMatricule, "Matricule non valide");
            else if (!Salarie.IsNomPrenomValide(txtNom.Text)) errorProvider1.SetError(txtNom, "Nom non valide");
            else if (!Salarie.IsNomPrenomValide(txtPrénom.Text)) errorProvider1.SetError(txtPrénom, "Prénom non valide");
            else if (!decimal.TryParse(txtSalaireBrut.Text, out parseSalaire)) errorProvider1.SetError(txtSalaireBrut, "Salaire non valide");
            else if (!decimal.TryParse(txtTauxCs.Text, out parseTauxCs)) errorProvider1.SetError(txtTauxCs, "Taux non valide");
            else if ((parseTauxCs < 0) || (parseTauxCs > 0.6m)) errorProvider1.SetError(txtTauxCs, "Taux non valide");
            else if (!Salarie.IsDateNaissanceValide(DateTime.Parse(txtDate.Text))) errorProvider1.SetError(txtDate, "Date de naissance non valide");
            else
            {
                if (chkCommercial.Checked)
                {
                    decimal parseChiffre = 0;
                    decimal parseCommission = 0;
                    if (!decimal.TryParse(txtChiffre.Text, out parseChiffre)) errorProvider1.SetError(txtChiffre, "Chiffre non valide");
                    else if (!decimal.TryParse(txtCommission.Text, out parseCommission)) errorProvider1.SetError(txtCommission, "Commmission non valide");
                    else
                    {
                        var salarieTmp = new Commercial(txtNom.Text,txtPrénom.Text,txtMatricule.Text,parseChiffre,parseCommission);
                        salarieTmp.SalaireBrut = parseSalaire;
                        salarieTmp.TauxCS = parseTauxCs;
                        salarieTmp.DateNaissance = DateTime.Parse(txtDate.Text);
                        salaries.Remove(salarie);
                        salaries.Add(salarieTmp);
                        
                        RefresBox();
                    }
                }
                else
                {
                    var salarieTmp = new Salarie(txtNom.Text, txtPrénom.Text, txtMatricule.Text);
                    salarieTmp.SalaireBrut = parseSalaire;
                    salarieTmp.TauxCS = parseTauxCs;
                    salarieTmp.DateNaissance = DateTime.Parse(txtDate.Text);
                    salaries.Remove(salarie);
                    salaries.Add(salarieTmp);
                    RefresBox();
                }

                

            }
            //if (salarie is Commercial commercial)
            //{
            //    decimal parseChiffre = 0;
            //    decimal parseCommission = 0;
            //    if (!decimal.TryParse(txtChiffre.Text, out parseChiffre)) errorProvider1.SetError(txtChiffre, "Chiffre non valide");
            //    else if (!decimal.TryParse(txtCommission.Text, out parseCommission)) errorProvider1.SetError(txtCommission, "Commmission non valide");
            //    else
            //    {
            //        commercial.ChiffreAffaire = parseChiffre;
            //        commercial.Commission = parseCommission;
            //    }
            //}
           



        }

        private void chkCommercial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCommercial.Checked)
            {
                gpCommercial.Visible = true;
            }
            else
            {
                gpCommercial.Visible = false;
            }
        }

        private void nouveauSalarie_Click(object sender, EventArgs e)
        {
            salarie = new Salarie();
            GestionBox(Etat.Modification);
            ClearBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            cbSearch.Items.Clear();
            listSalarie.Items.Clear();
            foreach (var item in salaries.SalariesNomCommencePar(txtSearch.Text))
            {
                cbSearch.Items.Add(item);
            }
            foreach (var item in salaries.SalariesNomCommencePar(txtSearch.Text))
            {
                listSalarie.Items.Add(item);
            }


        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = (Salarie)cbSearch.SelectedItem;
            salarie = (Salarie)listSalarie.SelectedItem;
            ChargerSalarie();
            //txtMatricule.Text = salarie.Matricule;
            //txtNom.Text = salarie.Nom;
            //txtPrénom.Text = salarie.Prenom;
            //txtSalaireBrut.Text = salarie.SalaireBrut.ToString();
            //txtTauxCs.Text = salarie.TauxCS.ToString();
            //txtDate.Text = salarie.DateNaissance.ToShortDateString();
            //if (salarie is Commercial commercial)
            //{
            //    chkCommercial.Checked = true;
            //    //var salarieTmp = (Commercial) salarie;
            //    //txtChiffre.Text = salarieTmp.ChiffreAffaire.ToString();
            //    //txtCommission.Text = salarieTmp.Commission.ToString();
            //    txtChiffre.Text = commercial.ChiffreAffaire.ToString();
            //    txtCommission.Text = commercial.Commission.ToString();

            //}
            //else
            //{
            //    chkCommercial.Checked = false;
            //}
            
        }

        private void listSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = (Salarie)listSalarie.SelectedItem;
            ChargerSalarie();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearBox();
            RefresBox();
            errorProvider1.Clear();
            GestionBox(Etat.Consultation);
        }
    }
}
