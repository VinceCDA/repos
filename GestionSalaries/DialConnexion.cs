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
using Utilitaires;

namespace GestionSalaraies 
{
    public partial class DialConnexion : Form
    {
        public DialConnexion()
        {
            InitializeComponent();
        }
        Utilisateurs utilisateurs;
        Utilisateur utilisateur;
        Roles roles;
        Role role;
        private void DialConnexion_Load(object sender, EventArgs e)
        {
            utilisateurs = new Utilisateurs();
            roles = new Roles();
            //ISauvegarde serialiseurUser = MonApplication.DispositifSauvegarde;
            //ISauvegarde serialiseurRoles = MonApplication.DispositifSauvegarde;
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
            roles.Load(serialiseur, Properties.Settings.Default.AppData);

        }
        #region Gestionnaires Evenements Validation

        /// <summary>
        /// Validation ID Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdentifiant_Validating(object sender, CancelEventArgs e)
        {

            if (IsIdCorrect(txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtIdentifiant, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, "Identifiant invalide");
                e.Cancel = true;
            }

        }
        /// <summary>
        /// Interception du traitement de la touche
        /// Assignation de dialogResult Cancel sur Escap
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMDP_Validating(object sender, CancelEventArgs e)
        {
            if (IsMotPasseCorrect(txtMDP.Text, txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtMDP, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtMDP, "Mot de passe incorrect");
                e.Cancel = true;
            }

        }
        #endregion



        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private bool IsIdCorrect(string id)
        {
            utilisateur = utilisateurs.UtilisateurByMatricule(txtIdentifiant.Text);
            if (String.IsNullOrEmpty(id)) return false;
            if (!char.IsLetter(id[0])) return false;
            if (id.Length < 3) return false;
            if (utilisateur == null) return false;
            if (utilisateur.Role.Description == null) return false;
            return true;
        }

        private bool IsMotPasseCorrect(string motPasse, string id)
        {
            if (String.IsNullOrEmpty(motPasse)) return false;
            if (motPasse.Length < 5) return false;
            return true;
            //return (motPasse == id);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            
            if (!(utilisateur.NombreEchecsConsecutifs >= 3))
            {
                if (utilisateur.Identifiant == txtIdentifiant.Text && utilisateur.MotDePasse == txtMDP.Text)
                {
                    ConnectionResultat(ConnectionResult.Connecté);

                }
                if (utilisateur.MotDePasse != txtMDP.Text)
                {
                    ConnectionResultat(ConnectionResult.MotPasseInvalide);
                }
            }
            else
            {
                utilisateur.CompteBloque = true;
                ConnectionResultat(ConnectionResult.CompteBloqué);
                
            }
               

        }
            
            
        
        private void ConnectionResultat(ConnectionResult result)
        {
            DialogResult = DialogResult.None;
            switch (result)
            {
                case ConnectionResult.Connecté:
                    MessageBox.Show("Connecté", "Connecté", MessageBoxButtons.OK);
                    utilisateur.NombreEchecsConsecutifs = 0;
                    this.DialogResult = DialogResult.OK;
                    break;
                case ConnectionResult.MotPasseInvalide:
                    utilisateur.NombreEchecsConsecutifs += 1;
                    MessageBox.Show($"Essai restant :{3 - utilisateur.NombreEchecsConsecutifs}", "Echec",  MessageBoxButtons.OK);
                    break;
                case ConnectionResult.CompteBloqué:
                    MessageBox.Show("Compte bloqué.", "Bloqué", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.Cancel;
                    break;
                default:
                    break;
            }
        }

        private void DialConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

