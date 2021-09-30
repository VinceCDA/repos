using ECommerceAPPWeb.DataAPI;
using NopCommerceBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ECommerceAPPWeb
{
    public partial class ListeProduits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetCategoriesAsync));
            RegisterAsyncTask(new PageAsyncTask(GetProductsAsync));
           
        }
        private async Task GetProductsAsync()
        {
            if (this.Context.Request.QueryString["CategoryId"] != null)
            {
                int categoryId = int.Parse(this.Context.Request.QueryString["CategoryId"]);
                int pageNum = 1;
                int pageSize = 10;
                GenererListeProduits(await PortailData.GetProductsAsync($"api/products/categoryId/{categoryId}/{pageNum}/{pageSize}"));
            }
            else
            {
                int parentCategoryId = 0;
                GenererListeCategoriesPrincipales(await PortailData.GetCategoriesPrincipalesAsync($"api/categories/Parent/{parentCategoryId}"));
            }
        }

        private void GenererListeCategoriesPrincipales(List<Category> categories)
        {
            gvProducts.Visible = false;
            dlCategories.Visible = true;
            dlCategories.RepeatColumns = 3;
            dlCategories.RepeatDirection = RepeatDirection.Vertical;
            dlCategories.RepeatLayout = RepeatLayout.Table;
            dlCategories.DataMember = nameof(Category);
            dlCategories.DataSource = categories;
            dlCategories.DataBind();
        }

        private void GenererListeProduits(List<ProductAbr> products)
        {
            gvProducts.Visible = true;
            dlCategories.Visible = false;
            gvProducts.DataMember = nameof(ProductAbr);
            gvProducts.DataSource = products;
            gvProducts.DataBind();
        }

        private async Task GetCategoriesAsync()
        {
            CreerMenuCategories(await PortailData.GetCategoriesAsync("api/categories"));
        }
        /// <summary>
        /// Création du menu dynamique des catégories
        /// Accès Catégorie ou sous-catégorie
        /// </summary>
        /// <param name="categories"></param>
        private void CreerMenuCategories(List<Category> categories)
        {
            var catParents = categories.Where(c => c.ParentCategoryId == 0).ToList();
            foreach (var categorie in catParents)
            {
                // Pas de sous-categorie
                if (categories.Where(c => c.ParentCategoryId == categorie.Id).Count() == 0)
                {
                    HtmlGenericControl li = new HtmlGenericControl("li");
                    li.Attributes.Add("class", "nav-item");
                    MenuListe.Controls.Add(li);
                    HtmlGenericControl lien = new HtmlGenericControl("a");
                    lien.Attributes.Add("href", $"ListeProduits?CategoryId={categorie.Id}");
                    lien.Attributes.Add("class", "nav-link");
                    lien.InnerText = $"{categorie.Name}";
                    li.Controls.Add(lien);
                }
                else
                {
                    HtmlGenericControl li = new HtmlGenericControl("li");
                    li.Attributes.Add("class", "nav-item dropdown");
                    HtmlGenericControl lien = new HtmlGenericControl("a");
                    lien.Attributes.Add("href", "#");
                    lien.Attributes.Add("id", $"navbarDropdownMenuLink{categorie.Id}");
                    lien.Attributes.Add("class", "nav-link dropdown-toggle");
                    lien.Attributes.Add("data-toggle", "dropdown");
                    lien.Attributes.Add("aria-haspopup", "true");
                    lien.Attributes.Add("aria-expanded", "false");
                    lien.InnerText = $"{categorie.Name}";
                    MenuListe.Controls.Add(li);
                    li.Controls.Add(lien);
                    HtmlGenericControl div = new HtmlGenericControl("div");
                    div.Attributes.Add("aria-labelledby", $"navbarDropdownMenuLink{categorie.Id}");
                    div.Attributes.Add("class", "dropdown-menu");
                    li.Controls.Add(div);
                    foreach (Category catEnfant in categories.Where(c => c.ParentCategoryId == categorie.Id))
                    {
                        HtmlGenericControl lien2 = new HtmlGenericControl("a");
                        lien2.Attributes.Add("href", $"ListeProduits?CategoryId={catEnfant.Id}");
                        lien2.Attributes.Add("class", "dropdown-item");
                        lien2.InnerText = $"{catEnfant.Name}";
                        div.Controls.Add(lien2);
                    }
                    
                }


            }

        }
    }
}