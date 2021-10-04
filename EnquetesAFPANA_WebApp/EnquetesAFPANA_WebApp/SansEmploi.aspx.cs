using EnquetesAFPANA_WebApp.DataAPI;
using EnquetesAFPANA_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnquetesAFPANA_WebApp
{
    public partial class SansEmploi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(EnregistrerReponse));
        }
        private async Task EnregistrerReponse()
        {
            try
            {
                string idSoumissionnaire = Request.QueryString["IdentifiantMailing"];
                Soumissionnaire soumissionnaire = await PortailData.GetSoumissionnaireAsync($"api/Soumissionnaires/{idSoumissionnaire}");
                soumissionnaire.DateEnregistrementReponse = DateTime.Now;
                soumissionnaire.ReponseEmploi = false;
                HttpResponseMessage reponse = await PortailData.PutSoumissionnaireAsync($"api/Soumissionnaires/{idSoumissionnaire}", soumissionnaire);
                if (reponse.IsSuccessStatusCode)
                {
                    Response.Redirect("Remerciements.aspx");
                }
                else
                {
                    Response.Redirect("Erreur.aspx");
                }
            }
            catch (Exception)
            {

                Response.Redirect("Erreur.aspx");
            }
        }
    }
}