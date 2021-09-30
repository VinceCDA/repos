using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace EcommerceAPPWeb.UserControls
{
      public partial class ProduitListe : System.Web.UI.UserControl
    {
        private string _titreProduit;
        private string _description;
        private decimal _prix;
        private int _idImage;
        private int _idProduit;

        public string CommandAdd;

        [Category("Data")]
        [Browsable(true)]
        [Description("Prix Produit")]
        [DisplayName("Prix Produit")]
        [PersistenceMode(PersistenceMode.Attribute)]
        public decimal Prix
        {
            get { return _prix; }
            set { 
                _prix = value;
                btnPrix.Value = string.Format("{0:c}", value);
                }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Description Produit")]
        [DisplayName("Description Produit")]
        [PersistenceMode(PersistenceMode.Attribute)]
        public string Description
        {
            get { return _description; }
            set { _description = value;
            txtDescription.InnerHtml = value;
            }
        }
        
        [Category("Data")]
        [Browsable(true)]
        [Description("Identifiant Produit")]
        [DisplayName("Identifiant Produit")]
        [PersistenceMode(PersistenceMode.Attribute)]
        public int IdProduit
        {
            get { return _idProduit; }
            set {
                _idProduit = value;
                btnCommander.Attributes["data-ProductId"] = value.ToString();
                //btnCommander.Attributes["onclick"] = $"ajouterPanier({value})";
                //btnPrix.Attributes["onclick"] = $"ajouterPanier({value})";
                }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Identifiant Produit")]
        [DisplayName("Identifiant Produit")]
        [PersistenceMode(PersistenceMode.Attribute)]
        public int IdImage
        {
            get { return _idImage; }
            set
            {
                _idImage = value;
                definirImageUrl(_idImage);
               
            }
        }
        private void definirImageUrl(int idImage)
        {            
            this.ImageProduit.ImageUrl = 
                $"https://localhost:44320/api/picture/GetPicture/{idImage}";
        }
      
      

        [Category("Data")]
        [Browsable(true)]
        [Description("Titre Image")]
        [DisplayName("Titre Image")]
        [PersistenceMode(PersistenceMode.Attribute)]
        public string TitreProduit
        {
            get { return _titreProduit; }
            set {
                _titreProduit = value;
                Title.InnerHtml = value;
            }
        }
       
    
    }
}