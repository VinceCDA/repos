using EnquetesAFPANA_WebApp.DataAPI;
using EnquetesAFPANA_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnquetesAFPANA_WebApp
{
    public partial class PageTests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetSoumissionnairesNoRep));
        }
        private async Task GetSoumissionnairesNoRep()
        {
            GenererListeSoumissionnairesNoRep(await PortailData.GetSoumissionnairesNoRepAsync($"api/soumissionnaires/NoReponse"));
        }
        private void GenererListeSoumissionnairesNoRep(List<Soumissionnaire> soumissionnaires)
        {
            AffichageSoumissionnaires.DataSource = soumissionnaires;
            AffichageSoumissionnaires.DataBind();
        }



    }
}