using Bibliotheque.BOL;
using Bibliotheque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque.WinUI
{
    public partial class AjoutAdherent : Form
    {
        public AjoutAdherent()
        {
            
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            //adherentBindingSource.DataSource = AdherentDAO.Instance.GetAll();
            adherentBindingSource.ResetCurrentItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adherentIDTextBox.Update();
            adherentBindingSource.ResetCurrentItem();
            adherentBindingSource.AddNew();


        }
    }
}
