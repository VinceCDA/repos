using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Banque.BOL;
using Banque.DAL;
using System.Globalization;

namespace Banque.WindowsGUI
   
{
    /// <summary>
    /// Création d'un nouveau compte de bénéficiaire des virements
    /// Cette fonction ne permet que la création de comptes externes
    /// </summary>
    /// 

    public partial class FrmNouveauCompte : Form
    {
       

        /// <summary>
        /// Ajout d'une nouvelle ligne Compte Externe
        /// </summary>
        public FrmNouveauCompte()
        {
            InitializeComponent();
            HashSet<CompteExterne> comptesExternes = CompteExterneDAC.Instance.GetComptesExternesByCodeClient(Globale.Client);
            if (comptesExternes.Count>0)
            {
                compteExterneBindingSource.DataSource = comptesExternes;
            }
            
            compteExterneBindingSource.AllowNew = true;
            this.compteExterneBindingSource.AddNew();
            erpCompte.DataSource = compteExterneBindingSource;
            codeBanqueTextBox.Validating += DemandeValidation;
            codeGuichetTextBox.Validating += DemandeValidation;
            numeroCompteTextBox.Validating += DemandeValidation;
            libelleCompteTextBox.Validating += DemandeValidation;
            cleRIBTextBox.Validating += DemandeValidation;
            codeBanqueTextBox.Focus();
        }

       

        private void BtnValider_Click(object sender, EventArgs e)
        {
            cleRIBTextBox.CausesValidation = true;
            this.Validate();
            CompteExterne compteExterne = compteExterneBindingSource.Current as CompteExterne;
            compteExterne.Client = Globale.Client;
            if (CompteExterne.IsControleCleRIBValide(compteExterne.CodeBanque,
                compteExterne.CodeGuichet,
                CompteExterne.Transcoder(compteExterne.NumeroCompte),
                compteExterne.CleRIB))
            {
                
                EnregistrerCompte(compteExterne);
            }

            else
            {
                erpCompte.SetError(cleRIBTextBox, string.Format(CultureInfo.CurrentCulture, Banque.BOL.Messages.Compte003, cleRIBTextBox.Text));
                DialogResult = DialogResult.None;
                cleRIBTextBox.CausesValidation = true;
            }
            
        }


        private void EnregistrerCompte(CompteExterne compteExterne)
        {

                     
            try
            {
                CompteExterneDAC.Instance.AddCompteExterne(compteExterne);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Le compte n'a pas pu être ajouté", MessageBoxButtons.OK);
            }
        }
      

        private void DemandeValidation(object sender, CancelEventArgs e)
        {
            TextBox input = sender as TextBox;
            erpCompte.SetError(input, string.Empty);
            if (string.IsNullOrEmpty(input.Text))
            {
                erpCompte.SetError(input, "Valeur obligatoire");
            }           
            
        }
    }
}