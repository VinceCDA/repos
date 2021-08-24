using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Banque;
using System.Text.RegularExpressions;

namespace BanqueWindowsGUI
   
{
    /// <summary>
    /// Création d'un nouveau compte  externe à la banque
    /// </summary>
    public partial class FrmNouveauCompte : Form
    {
        Compte compte = new Compte();
        Comptes listeComptes = new Comptes();
        public FrmNouveauCompte()
        {
            compte.CodeClient = "23456754";
            InitializeComponent();
        }

        public FrmNouveauCompte(Comptes comptes) :this()
        {
            listeComptes = comptes;
        }
        #region Method
        /// <summary>
        /// Controle du code banque ou guichet
        /// </summary>
        /// <param name="code">Code Banque ou guichet</param>
        /// <returns>Retourne true si le numero est invalide</returns>
        private bool ControlCode(string code)
        {
            
            if (String.IsNullOrEmpty(code) || code.Length > 5 || !(new Regex("^[0-9]+$").IsMatch(code) ))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Controle du numéro de compte.
        /// </summary>
        /// <param name="numero">Numéro de compte</param>
        /// <returns>Retourne true si le numero est invalide</returns>
        private bool ControleNumCompte(string numero)
        {
            if (String.IsNullOrEmpty(numero) || numero.Length > 11 || !(new Regex("^[A-Z0-9]+$").IsMatch(numero)))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remplacement des miniscules par majuscules
        /// et ajout de 0
        /// </summary>
        /// <param name="numero">Numéro compte</param>
        /// <returns>Retourne string traité</returns>
        private string TraitementNumCompte(string numero)
        {
            string output = "";
            foreach (char item in numero)
            {
                
                if (!Char.IsDigit(item))
                {
                    output += Char.ToUpper(item);
                }
                else
                {
                    output += item;
                }
            }
            return output.PadLeft(11, '0');
        }
        /// <summary>
        /// Valide les donnees de la textbox si correct.
        /// </summary>
        /// <param name="textBox">TextBox a verifié</param>
        /// <param name="compteTxt">Champ a attribuer</param>
        /// <returns>Retourne true si correct et modifie la string</returns>
        private bool ValidationCode(TextBox textBox, string compteTxt)
        {
            if (ControlCode(textBox.Text))
            {
                errorProvider.SetError(textBox, "Champ invalide");
                compteTxt = "";
                return false;
            }
            else
            {
                textBox.Text = textBox.Text.PadLeft(5, '0');
                errorProvider.SetError(textBox, string.Empty);
                compteTxt = textBox.Text;
                
                return true;
                
            }
        }
        /// <summary>
        /// Converti le numéro de compte suivant la table Hollerith.
        /// </summary>
        /// <param name="numero">Numéro de compte.</param>
        /// <returns>Retourne string convertie</returns>
        private string ConvertNumCompte(string numero)
        {
            string outputString = "";
            int outputChar = 0;
            foreach (char item in numero)
            {
                if (Hollerith.Transcoder(item,out outputChar))
                {
                    outputString += outputChar;
                }
                else
                {
                    outputString += item;
                }
            }
            return outputString;

        }
        /// <summary>
        /// Controle de la cle RIB.
        /// </summary>
        /// <param name="codeBanque">Code de la banque.</param>
        /// <param name="codeGuichet">Code du Guichet</param>
        /// <param name="numeroCompte">Numero de compte</param>
        /// <returns>Retourne la clé suivant les parametre</returns>
        private string ControlRib(string codeBanque,string codeGuichet,string numeroCompte)
        {
            string cleRibTestString = "";
            long.TryParse(codeBanque + codeGuichet, out long parseCodeBanGui);
            cleRibTestString += parseCodeBanGui % 97;
            long.TryParse(cleRibTestString + ConvertNumCompte(numeroCompte), out long parseRibTestLong);
            return (97 - (parseRibTestLong * 100) % 97).ToString();
        }
        
        
        private void AjouterCompte(Compte nouveauCompte)
        {
            listeComptes.Add(nouveauCompte);
        }
        #endregion
        #region Event
        private void FrmNouveauCompte_Load(object sender, EventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            AjouterCompte(compte);
            this.DialogResult = DialogResult.OK;
            // Pour ne pas sortir du dialog avec DialogResult.OK
            // Lorsque des erreurs subsistent 
            // Utiliser this.DialogResult = DialogResult.None
        }

        private void BtnAbandonner_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void codeBanqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            //e.Cancel = true;
            //if (ValidationCode(codeBanqueTextBox,out compte.CodeBanque))
            //{
            //   e.Cancel = false;
            //   codeGuichetTextBox.Select();
            //}
            if (ControlCode(codeBanqueTextBox.Text))
            {
                errorProvider.SetError(codeBanqueTextBox, "Champ invalide");
            }
            else
            {
                e.Cancel = false;
               codeBanqueTextBox.Text = codeBanqueTextBox.Text.PadLeft(5, '0');
                errorProvider.SetError(codeBanqueTextBox, string.Empty);
               compte.CodeBanque = codeBanqueTextBox.Text;
               codeGuichetTextBox.Select();
            }
            

        }

        private void codeGuichetTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;


            //if (ValidationCode(codeGuichetTextBox, compte.CodeGuichet))
            //{
            //    e.Cancel = false;
            //    numeroCompteTextBox.Select();
            //}
            if (ControlCode(codeGuichetTextBox.Text))
            {
                errorProvider.SetError(codeGuichetTextBox, "Champ invalide");
            }
            else
            {
                e.Cancel = false;
                codeGuichetTextBox.Text = codeGuichetTextBox.Text.PadLeft(5, '0');
                errorProvider.SetError(codeGuichetTextBox, string.Empty);
                compte.CodeGuichet = codeGuichetTextBox.Text;
                numeroCompteTextBox.Select();
            }
        }

        private void numeroCompteTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            numeroCompteTextBox.Text = TraitementNumCompte(numeroCompteTextBox.Text);
            if (ControleNumCompte(numeroCompteTextBox.Text))
            {
                errorProvider.SetError(numeroCompteTextBox, "Champ invalide");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(numeroCompteTextBox, string.Empty);
                compte.Numero = numeroCompteTextBox.Text;
                cleRIBTextBox.Select();
                
            }
        }

        private void cleRIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (!(ControlRib(codeBanqueTextBox.Text,codeGuichetTextBox.Text,numeroCompteTextBox.Text) == cleRIBTextBox.Text))
            {
                errorProvider.SetError(cleRIBTextBox, "Champ invalide");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cleRIBTextBox, string.Empty);
                compte.CleRIB = cleRIBTextBox.Text;
                libellécompteTextBox.Select();
            }
        }

        private void libellécompteTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (String.IsNullOrEmpty(libellécompteTextBox.Text))
            {
                errorProvider.SetError(libellécompteTextBox, "Champ invalide");
            }
            else
            {
                errorProvider.SetError(libellécompteTextBox, string.Empty);
                compte.LibelleCompte = libellécompteTextBox.Text;
                btnValider.Select();
            }
        }
        #endregion
    }
}
