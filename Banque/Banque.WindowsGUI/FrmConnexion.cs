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
using System.Data.SqlClient;

namespace Banque.WindowsGUI

{
    public partial class FrmConnexion : Form
    {

        public FrmConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Demande de connexion
        /// Test des valeurs retournées par la procédure stockée 
        /// appelée pour contrôler les informations de connexion 
        /// au service de la gestion des virements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool connexionValide = false;
            erpConnexion.Clear();


            switch (controlerInfosConnexion(txtCodeClient.Text, txtCodeSecret.Text))
            {
                case StatutAuthentification.IDInvalide:
                    erpConnexion.SetError(txtCodeClient, "Le code client saisi n'est pas valide. Corrigez S.V.P.");
                    txtCodeClient.SelectAll();
                    txtCodeClient.Focus();
                    break;
                case StatutAuthentification.MotPasseInvalide:
                    erpConnexion.SetError(txtCodeSecret, "Le code secret communiqué n'est pas valide. corrigez S.V.P.");
                    txtCodeSecret.SelectAll();
                    txtCodeSecret.Focus();
                    break;
                case StatutAuthentification.CompteBloqué:
                    erpConnexion.SetError(txtCodeClient, "Votre compte utilisateur est bloqué.Prenez contact avec notre hotline.");
                    btnAbandonner.Focus();
                    break;
                case StatutAuthentification.ConnexionOK:
                    connexionValide = true;
                    break;
                default:
                    erpConnexion.SetError(txtCodeClient, "Incident imprévu.... Essayez de nouveau !");
                    break;
            }
            if (!connexionValide)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {

                this.DialogResult = DialogResult.OK;
                Client clientCourant = ClientDAC.Instance.GetClientById(txtCodeClient.Text);
                clientCourant.Guichet = GuichetDAC.Instance.GetGuichetByClient(clientCourant);
                clientCourant.Comptes = CompteDAC.Instance.GetComptesByCodeClient(clientCourant);
                //
                Globale.Client = clientCourant;
            }
        }
        /// <summary>
        /// Cette fonction permet de déterminer l'exactitude des informations fournies
        /// pour la connexion au service de gestion des virements
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="MotPasse"></param>
        /// <returns></returns>
        private StatutAuthentification controlerInfosConnexion(string id, string motPasse)
        {

            if (id.Length == 0) { return StatutAuthentification.IDInvalide; }
            if (motPasse.Length == 0) { return StatutAuthentification.MotPasseInvalide; }
            return ClientDAC.Instance.Authentifier(id, motPasse);
        }

        private void FrmConnexion_Shown(object sender, EventArgs e)
        {
            txtCodeClient.Focus();
        }
    }
}
