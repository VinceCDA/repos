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
    public partial class FrmMereFille : Form
    {
        public FrmMereFille()
        {
            InitializeComponent();
        }


        private void btnAjouterMereFille_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString);
            sqlConnection.Open();
            SqlCommand cmdAjouterMere = Transactions.CreerCommandeMere(sqlConnection, txtNomMere.Text);
            cmdAjouterMere.ExecuteNonQuery();
            SqlCommand cmdAjouterFille = Transactions.CreerCommandeFille(sqlConnection,cmdAjouterMere,txtIdFille.Text,txtNomFille.Text);
            txtRowsAffected.Text = cmdAjouterFille.ExecuteNonQuery().ToString();
            txtReturnValue.Text = cmdAjouterFille.Parameters[0].Value.ToString();
            txtIdMere.Text = cmdAjouterMere.Parameters[1].Value.ToString();
            sqlConnection.Close();

        }

      
    }
}

