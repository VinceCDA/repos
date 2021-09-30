using NopCommerceBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerceAPPWeb
{
    public partial class AfficherPanier : System.Web.UI.Page
    {

        protected Panier panier = null;

        protected void Page_PreInit(object sender, EventArgs e)
        {
            panier = Session["monPanier"] as Panier;
        } 
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack && panier != null)
            {
                AffichagePanier.DataSource = panier.Select();
                AffichagePanier.DataBind();
            }

        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Supprimer":
                    panier.Delete(Convert.ToInt32(e.CommandArgument));
                    break;
                case "Modifier":
                    int index = Convert.ToInt32(e.CommandArgument);
                    TextBox quantite = this.AffichagePanier.Items[index].FindControl("Quantite") as TextBox;
                    Label id = this.AffichagePanier.Items[index].FindControl("IdProduit") as Label;
                    panier.Update(int.Parse(id.Text), int.Parse(quantite.Text));
                    break;
                default:
                    break;
            }
            AffichagePanier.DataSource = panier.Select();
            AffichagePanier.DataBind();

        }

        protected void AffichagePanier_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            switch (e.Item.ItemType)
            {
                case ListItemType.AlternatingItem:
                    break;
                case ListItemType.EditItem:
                    break;
                case ListItemType.Footer:
                    Label lblQte = (Label)e.Item.FindControl("QuantiteTotale");
                    lblQte.Text = panier.QteProduits.ToString() + " produit(s)";
                    Label lblMontant = (Label)e.Item.FindControl("MontantTotal");
                    lblMontant.Text = string.Format("{0:c}", panier.TotalPanier);
                    Control hlCommander = e.Item.FindControl("hlCommander");
                    hlCommander.Visible = (panier.TotalPanier > 0);

                    break;
                case ListItemType.Header:
                    break;
                case ListItemType.Item:
                    break;
                case ListItemType.Pager:
                    break;
                case ListItemType.SelectedItem:
                    break;
                case ListItemType.Separator:
                    break;
                default:
                    break;
            }
        }
    }
}