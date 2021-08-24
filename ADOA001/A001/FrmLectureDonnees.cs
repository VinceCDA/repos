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
    public partial class FrmLectureDonnees : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlRdr;
        public FrmLectureDonnees()
        {
            sqlConnection.ConnectionString = Properties.Settings.Default.ADO_NetConnectionString;
            sqlConnection.Open();
            InitializeComponent();
        }
        /// <summary>
        /// Exécution de la méthode ExecuteReader  
        /// Chargement de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCommandeParametree_Click_1(object sender, EventArgs e)
        {
            string strCmdSql = txtRequete.Text;
            sqlCmd.CommandText = strCmdSql;
            sqlCmd.Connection = sqlConnection;
            SqlParameter sqlParameter = sqlCmd.Parameters.Add("@CustomerID", SqlDbType.Char);
            sqlCmd.Parameters["@CustomerID"].Value = txtCustomerID.Text;
            sqlParameter.Direction = ParameterDirection.Input;
            sqlRdr = sqlCmd.ExecuteReader();
            while (sqlRdr.Read())
            {
                lstDernieresCommandes.Items.Add(sqlRdr.GetString(0)+" "+sqlRdr.GetString(1)+" "+sqlRdr.GetString(2)+" "+sqlRdr.GetInt32(3)+" "+sqlRdr.GetDateTime(4).ToShortDateString());
             
            }
            sqlRdr.Close();
        }
    }
}
