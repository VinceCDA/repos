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
    public partial class ListeAdherents : Form
    {
        DB dbBiblio = new DB();
        Adherent adherent = new Adherent();
        AdherentDAO adherentDAO = new AdherentDAO();
        HashSet<Adherent> adherents = new HashSet<Adherent>();
        public ListeAdherents()
        {
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            dbBiblio.GetDBConnection();
            adherents = adherentDAO.GetAll();
            InitializeComponent();
            foreach (var item in adherents)
            {
                listBox1.Items.Add(item.AdherentID+" "+item.Nom+" "+item.Prenom);
            }

        }
    }
}
