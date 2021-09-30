using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECommerceAPPWeb.DataAPI;
using NopCommerceBOL;

namespace ECommerceAPPWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetCategoriesAsync));
        }
        
        private async Task GetCategoriesAsync()
        {
            List<Category> categories = await PortailData.GetCategoriesAsync("api/categories");
            var catParents = categories.Where(c => c.ParentCategoryId == 0).ToList();
            foreach (var categorie in catParents)
            {

            }
        }
    }
}