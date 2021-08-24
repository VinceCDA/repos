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
using Bibliotheque.DAL;

namespace Bibliotheque.WinUI
{
    public partial class TestEnfants : Form
    {
        public TestEnfants()
        {
            InitializeComponent();
            adherentBindingSource.DataSource = AdherentDAO.Instance.GetAll();
        }

        private void adherentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Adherent adherent = adherentBindingSource.Current as Adherent;
            pretBindingSource.DataSource = AdherentDAO.Instance.GetPret(adherent.AdherentID);
        }
    }
}
