using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Banque.BOL;
using Banque.DAL;
using System.Windows.Forms;

namespace Banque.WindowsGUI
{
    public partial class FrmVirement : Form
    {
        enum ContexteAfichage
        {
            ErreurTrancaction,
            TransactionValide,
            SoldeInsuffisant,
            MontantIncorrect,
            CompteIdentique,
            NonAutorise
        }
        public FrmVirement()
        {
            InitializeComponent();
            clientBindingSource.DataSource = Globale.Client;
            comptesEmetteurBindingSource.DataSource = CompteDAC.Instance.GetComptesByCodeClient(Globale.Client);
            foreach (var item in CompteExterneDAC.Instance.LiaisionsComptes(Globale.Client))
            {
                comptesDestinationBindingSource.Add(item as CompteBase);
            }
            datePrelevementDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            datePrelevementDateTimePicker.MaxDate = DateTime.Now.AddDays(10);
            lblDateInterval.Text = $"Entre le {datePrelevementDateTimePicker.MinDate.ToShortDateString()} et le {datePrelevementDateTimePicker.MaxDate.ToShortDateString()}";
            
        }
        /// <summary>
        /// Affichage des erreurs suivant l'énum
        /// </summary>
        /// <param name="contexte"></param>
        private void GererContexteAffichage(ContexteAfichage contexte)
        {
            this.SuspendLayout();
            switch (contexte)
            {
                case ContexteAfichage.ErreurTrancaction:
                    MessageBox.Show(Properties.Resources.stringErreurTransaction, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    break;
                case ContexteAfichage.TransactionValide:
                    MessageBox.Show(Properties.Resources.stringTransactionValid, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    DialogResult dialogResult = MessageBox.Show(Properties.Resources.stringVirementOther, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                    break;
                case ContexteAfichage.SoldeInsuffisant:
                    MessageBox.Show(Properties.Resources.stringSoldeInsufisant, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    break;
                case ContexteAfichage.MontantIncorrect:
                    MessageBox.Show(Properties.Resources.stringIncorrectInput, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    break;
                case ContexteAfichage.CompteIdentique:
                    MessageBox.Show(Properties.Resources.stringSameAccount, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    break;
                case ContexteAfichage.NonAutorise:
                    MessageBox.Show(Properties.Resources.stringTransactionDeny, Properties.Resources.stringTitreMessageBox, MessageBoxButtons.OK);
                    break;
                default:
                    break;
            }
            this.ResumeLayout();
        }
        /// <summary>
        /// Si sortie du dialogue modal avec OK
        /// Raffraichissement de la liste déroulante des comptes destinataires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreerCompte_Click(object sender, EventArgs e)
        {
            FrmNouveauCompte frmNouveauCompte = new FrmNouveauCompte();
            if (frmNouveauCompte.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>Banque
        /// Si aucune erreur, validation et enregistrement dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderVirement_Click(object sender, EventArgs e)
        {
            Virement virement = new Virement { DatePrelevement = datePrelevementDateTimePicker.Value, MotifVirement = motifVirementTextBox.Text};
            var compteEmmetteur = comptesEmetteurBindingSource.Current as Compte;
            var compteDestinataire = comptesDestinationBindingSource.Current as CompteBase;
            GererContexteAffichage((ContexteAfichage)VirementDAC.Instance.CheckDemandeVirement(compteEmmetteur,compteDestinataire,coutVirementTextBox.Text,virement));
        }


    }
}
