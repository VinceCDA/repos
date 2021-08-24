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
using Bibliotheque.BOL;

namespace Bibliotheque.WinUI
{
    public partial class TestDataBind : Form
    {
       // BindingSource bsPrets = new BindingSource();
        public TestDataBind()
        {

            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            adherentBindingSource.DataSource = AdherentDAO.Instance.GetAll();
            button1.DataBindings.Add("Text", textBox1, "Text");
            
            //pretBindingSource.DataSource = adherentBindingSource;
            //pretBindingSource.DataMember = "Prets";

        }

        private void adherentBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            Adherent adherent = adherentBindingSource.Current as Adherent;
            pretBindingSource.DataSource = adherent.Prets;
          //  pretBindingSource.DataSource = adherent.Prets;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adherent adherent = adherentBindingSource.Current as Adherent;
            MessageBox.Show(adherent.Nom, "Adherent", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            adherentBindingSource.AllowNew = true;
            adherentBindingSource.AddNew();
        }
    }
}
