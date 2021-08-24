using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A001
{
    public partial class FrmCommande : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        public FrmCommande()
        {
            sqlConnection.ConnectionString = Properties.Settings.Default.ADO_NetConnectionString;
            sqlConnection.Open();
            InitializeComponent();
        }
        /// <summary>
        /// Requête exécutée avec la méthode ExecuteNonQuery 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string strCmdSql = txtRequeteNonQuery.Text;
                sqlCmd.CommandText = strCmdSql;
                sqlCmd.Connection = sqlConnection;
                txtResultatNonQuery.Text = sqlCmd.ExecuteNonQuery().ToString();
            }
            catch
            {
                txtResultatNonQuery.Text = "ERR";
            }
        }
        /// <summary>
        /// Requête simple exécutée avec la méthode ExecuteScalar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSansParametre_Click(object sender, EventArgs e)
        {
            string strCmdSql = "SELECT COUNT(*) FROM Customers";
            sqlCmd.CommandText = strCmdSql;
            sqlCmd.Connection = sqlConnection;
            txtResultatSansParametre.Text = sqlCmd.ExecuteScalar().ToString();
        }
        /// <summary>
        /// Requête libre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuterTexte_Click(object sender, EventArgs e)
        {
            try
            {
                string strCmdSql = txtResultatRequeteLibre.Text;
                sqlCmd.CommandText = strCmdSql;
                sqlCmd.Connection = sqlConnection;
                txtResultatTexte.Text = sqlCmd.ExecuteScalar().ToString();
            }
            catch 
            {
                txtResultatTexte.Text = "ERR";
            }

        }
        /// <summary>
        /// Requête avec paramètre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvecParametre_Click(object sender, EventArgs e)
        {
            string strCmdSql = String.Format("SELECT COUNT(OrderID) FROM Orders WHERE CustomerID = '{0}'",txtCustomerID.Text);
            sqlCmd.CommandText = strCmdSql;
            sqlCmd.Connection = sqlConnection;
            txtResultatAvecParametre.Text = sqlCmd.ExecuteScalar().ToString();
        }

      
       
    }
}
