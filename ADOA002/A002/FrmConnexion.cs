using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A002
{
    public enum InfosConnexion
    {
        ConnexionOK = 0,
        UtilisateurInconnu = -101,
        CompteBloque = -102,
        MotPasseInvalide = -103,
        ApplicationInexistante = -104,
        RoleInexistant = -105,
        ProblemeConnexion = -106
    }
    public partial class FrmConnexion : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();

        public FrmConnexion()
        {
            InitializeComponent();
            this.Text = string.Format("{0}-Identifiez-vous", Properties.Settings.Default.NomApplication);
        }

        /// <summary>
        /// Demande de connexion
        /// Test des valeurs retournées par la procédure stockée 
        /// appelée pour contrôler les informations de connexion 
        /// au service de l'application des utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool connexionValide = false;
            erpConnexion.SetError(txtMotPasse, string.Empty);
            erpConnexion.SetError(txtIDUtilisateur, string.Empty);
            
            switch (ControlerInfosConnexion(txtIDUtilisateur.Text, txtMotPasse.Text,Properties.Settings.Default.NomApplication))
            {
                case InfosConnexion.UtilisateurInconnu:
                    erpConnexion.SetError(txtIDUtilisateur, "L'identifiant saisi n'est pas valide. Corrigez S.V.P.");
                    txtIDUtilisateur.SelectAll();
                    txtIDUtilisateur.Focus();
                    break;
                case InfosConnexion.MotPasseInvalide:
                    erpConnexion.SetError(txtMotPasse, "Le mot de passe communiqué n'est pas valide. corrigez S.V.P.");
                    txtMotPasse.SelectAll();
                    txtMotPasse.Focus();
                    break;

                case InfosConnexion.CompteBloque:
                    erpConnexion.SetError(txtIDUtilisateur, "Votre compte utilisateur est bloqué.Prenez contact avec notre hotline.");
                    btnAbandonner.Focus();
                    break;
                case InfosConnexion.ApplicationInexistante:
                    erpConnexion.SetError(txtIDUtilisateur, "Application inexistante.");
                    btnAbandonner.Focus();
                    break;
                case InfosConnexion.RoleInexistant:
                    erpConnexion.SetError(txtIDUtilisateur, "Vous ne pouvez pas accéder à cette application. Voir votre administrateur.");
                    btnAbandonner.Focus();
                    break;
                case InfosConnexion.ProblemeConnexion:
                    erpConnexion.SetError(txtIDUtilisateur, "Problèmes de connexion.Vous ne pouvez accéder actuellement à l'application.");
                    btnAbandonner.Focus();
                    break;
                case InfosConnexion.ConnexionOK:
                    connexionValide = true;
                    break;
                default:
                    break;
            }
            if (!connexionValide)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Cette fonction permet de déterminer l'exactitude des informations fournies
        /// pour la connexion au service de gestion des utilisateurs
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="MotPasse"></param>
        /// <returns></returns>
        private InfosConnexion ControlerInfosConnexion(string identifiant, string motPasse,string nomApplication)
        {
            sqlConnection.ConnectionString = Properties.Settings.Default.ADO_NetConnectionString;
            sqlConnection.Open();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlReturnValue = sqlCmd.Parameters.Add("@Return_Value", SqlDbType.Int);
            sqlReturnValue.Direction = ParameterDirection.ReturnValue;
            SqlParameter sqlParameterUserID = sqlCmd.Parameters.Add("@IDUtilisateur", SqlDbType.Char);
            sqlParameterUserID.Direction = ParameterDirection.Input;
            sqlCmd.Parameters["@IDUtilisateur"].Value = identifiant;
            SqlParameter sqlParameterPassword = sqlCmd.Parameters.Add("@MotPasseClair", SqlDbType.Char);
            sqlParameterPassword.Direction = ParameterDirection.Input;
            sqlCmd.Parameters["@MotPasseClair"].Value = motPasse;
            SqlParameter sqlParameterAppID = sqlCmd.Parameters.Add("@NomApplication", SqlDbType.Char);
            sqlParameterAppID.Direction = ParameterDirection.Input;
            sqlCmd.Parameters["@NomApplication"].Value = nomApplication;
            SqlParameter sqlParameterRoleID = sqlCmd.Parameters.Add("@IDRole", SqlDbType.UniqueIdentifier);
            sqlParameterRoleID.Direction = ParameterDirection.Output;
            sqlCmd.CommandText = "psUtilisateur_Authentifier";
            sqlCmd.ExecuteNonQuery();
            sqlConnection.Close();
            return (InfosConnexion)sqlCmd.Parameters[0].Value;
        }

        private void FrmConnexion_Shown(object sender, EventArgs e)
        {
            txtIDUtilisateur.Focus();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }


    }
}
