using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;
using IsolationLevel = System.Transactions.IsolationLevel;

namespace A003
{
    public partial class FrmTransaction : Form
    {
        public FrmTransaction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gestion des ajouts avec transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (rdbLocale.Checked) GererTransactionLocale();  
            else GererTransactionScope();
            
        }

        private void GererTransactionScope()
        {
            // Transaction Scope 
            // Toute connexion ouverte dans la portée représentée par le bloc using 
            // et concerant une ressource de type TransactionScope
            // est automatiquement ajoutée à la transaction en cours.
            // Toutes les instructions exécutées avec les connexions ouvertes dans cette portée 
            // seront pilotées par cette transaction (dans cette portée bien entendu).
            using (var scope = new TransactionScope())
            {
                int idMere;
                using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString)) 
                {
                    SqlCommand oCommand = new SqlCommand();
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Connection = sqlConnection;
                    oCommand.CommandText = "psMere_insert";
                    sqlConnection.Open();
                    SqlCommandBuilder.DeriveParameters(oCommand);
                    oCommand.Parameters[2].Value = txtNomMere.Text;
                    oCommand.Parameters[1].Direction = ParameterDirection.Output;
                    oCommand.Parameters[3].Direction = ParameterDirection.Output;
                    oCommand.ExecuteNonQuery();
                    idMere = (int)oCommand.Parameters[1].Value;
                }

                using (var scopeFille1 = new TransactionScope()) 
                {
                    using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString))
                    {

                        SqlCommand oCommand = new SqlCommand();
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Connection = sqlConnection;
                        oCommand.CommandText = "psFille_insert";
                        sqlConnection.Open();
                        SqlCommandBuilder.DeriveParameters(oCommand);
                        //IdMere
                        oCommand.Parameters[1].Value = idMere;
                        //Idille
                        oCommand.Parameters[2].Value = int.Parse(txtIdFille.Text);
                        //NomFille
                        oCommand.Parameters[3].Value = txtNomFille.Text;
                        oCommand.Parameters[4].Direction = ParameterDirection.Output;
                        oCommand.ExecuteNonQuery();

                    }
                    scopeFille1.Complete();
                }
                
                using (var scopeFille2 = new TransactionScope())
                {
                    using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString))
                    {

                        SqlCommand oCommand = new SqlCommand();
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Connection = sqlConnection;
                        oCommand.CommandText = "psFille_insert";
                        sqlConnection.Open();
                        SqlCommandBuilder.DeriveParameters(oCommand);
                        //IdMere
                        oCommand.Parameters[1].Value = idMere;
                        //Idille
                        oCommand.Parameters[2].Value = int.Parse(txtIdFille2.Text);
                        //NomFille
                        oCommand.Parameters[3].Value = txtNomFille2.Text;
                        oCommand.Parameters[4].Direction = ParameterDirection.Output;
                        oCommand.ExecuteNonQuery();

                    }
                    scopeFille2.Complete();
                }
                scope.Complete();
                txtIdMere.Text = idMere.ToString();

            }
            //IsolationLevel isolationLevel = Transaction.Current.IsolationLevel;
            //TimeSpan defaultTimeout = TransactionManager.DefaultTimeout;
            //TimeSpan maximumTimeout = TransactionManager.MaximumTimeout;
            //transctional code…
            //scope.Complete();
        }

        private void GererTransactionLocale()
        {
            using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString)) 
            {
                SqlCommand oCommand = new SqlCommand();
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = sqlConnection;
                oCommand.CommandText = "psMere_insert";
                sqlConnection.Open();
                SqlCommandBuilder.DeriveParameters(oCommand);
                oCommand.Parameters[2].Value = txtNomMere.Text;
                oCommand.Parameters[1].Direction = ParameterDirection.Output;
                oCommand.Parameters[3].Direction = ParameterDirection.Output;
                oCommand.ExecuteNonQuery();
                //idMere = (int)oCommand.Parameters[1].Value;
            }
            // Transaction locale 
            // Pour des transactions simples portant sur une seule connexion
            // Choix de la connexion et des commandes gérées au sein de cette transaction 
            // Toutes les instructions exécutées avec les connexions ouvertes dans cette portée 
            // seront pilotées par cette transaction (dans cette portée bien entendu).
        }       

    }
}


