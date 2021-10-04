using EnquetesAFPANA_WebApp.DataAPI;
using EnquetesAFPANA_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnquetesAFPANA_WebApp
{
    public partial class Enquete_Partie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetSoumissionnaire));
        }
        private async Task GetSoumissionnaire()
        {
            StringBuilder sb = new StringBuilder();
            string idSoumissionnaire = Request.QueryString["IdentifiantMailing"];
            VueSoumissionnaire soumissionnaireMV = await PortailData.GetVueSoumissionnaireAsync($"api/VueSoumissionnaires/{idSoumissionnaire}");

            sb.Append($@"<span>Bonjour {soumissionnaireMV.TitreCiviliteComplet} {soumissionnaireMV.PrenomBeneficiaire} {soumissionnaireMV.NomBeneficiaire} </span><br/>");
            sb.Append(@"<span>Merci de consacrer quelques instants à la réponse à notre enquête.</span><br/>");
            sb.Append($@"<span>Avez-vous exercé un emploi depuis le {soumissionnaireMV.DateSortieBeneficiaire.Value.ToLongDateString()}</span><br/>");
            this.titreEnquete.InnerHtml = string.Format($@"<span>{soumissionnaireMV.LibelleQuestionnaire}</span><br/>");
            this.introduction.InnerHtml = sb.ToString();
           }
    }
}