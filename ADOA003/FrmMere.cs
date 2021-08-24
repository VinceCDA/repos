using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A003
{
    public partial class FrmMere : Form
    {
        public FrmMere()
        {
            InitializeComponent();
        }

        private void btnAjouterMere_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString);
            sqlConnection.Open();
            SqlCommand cmdAjouterMere = Transactions.CreerCommandeMere(sqlConnection,txtNomMere.Text);
            txtRowsAffected.Text = cmdAjouterMere.ExecuteNonQuery().ToString();
            txtIdMere.Text = cmdAjouterMere.Parameters[1].Value.ToString();
            txtReturnValue.Text = cmdAjouterMere.Parameters[0].Value.ToString();
            // A compléter

            // Fermeture de la connexion
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
        }

      

    }
}
