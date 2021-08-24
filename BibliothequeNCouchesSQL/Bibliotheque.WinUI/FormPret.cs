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
    public partial class FormPret : Form
    {
        DB dbBiblio = new DB();
        Adherent adherent = new Adherent();
        AdherentDAO adherentDAO = new AdherentDAO();
        Livre livre = new Livre();
        Exemplaire exemplaire = new Exemplaire();
        HashSet<Adherent> adherents = new HashSet<Adherent>();
        HashSet<Pret> prets = new HashSet<Pret>();
        public FormPret()
        {
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            adherents = adherentDAO.GetAll();
            dbBiblio.GetDBConnection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adherent = adherentDAO.GetByID(txtAdherentId.Text);
            txtAdherentNom.Text = adherent.Nom;
            txtAdherentPrenom.Text = adherent.Prenom;
            adherent.Prets.UnionWith(adherentDAO.GetPret(txtAdherentId.Text));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            livre = adherentDAO.GetLivreByID(txtIsbn.Text);
            txtTitre.Text = livre.Titre;
            foreach (var item in livre.Exemplaires)
            {
                if (item.Empruntable == true)
                {
                    listExemplaire.Items.Add(item.IdExemplaire.ToString());
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (adherentDAO.TransacPret(adherent, int.Parse(listExemplaire.SelectedItem.ToString())))
            {
                MessageBox.Show(Properties.Resources.StringPretValide, Properties.Resources.StringBox, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Properties.Resources.StringPretRefuse, Properties.Resources.StringBox, MessageBoxButtons.OK);
            }
            
        }
    }
}
