using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnquetesAFPANA_WebApp.DataAPI;
using EnquetesAFPANA_WebApp.Models;
using Newtonsoft.Json;

namespace EnquetesAFPANA_WebApp
{
    public partial class Emploi : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                Page.RegisterAsyncTask(new PageAsyncTask(async () =>
                {
                    typecontrat.DataSource = JsonConvert.DeserializeObject(await PortailData.GetTypeContratListAsync());
                    rdBtnListDuree.DataSource = JsonConvert.DeserializeObject(await PortailData.GetDureeContratListAsync());
                    typecontrat.DataTextField = "libelleTypeContrat";
                    typecontrat.DataValueField = "idtypeContrat";
                    rdBtnListDuree.DataTextField = "libelleDureeContrat";
                    rdBtnListDuree.DataValueField = "idDureeContrat";
                    typecontrat.DataBind();
                    rdBtnListDuree.DataBind();
                }));
                Page.ExecuteRegisteredAsyncTasks();
            }
            
            
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void ChkDateDebutContrat_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Page.RegisterAsyncTask(new PageAsyncTask(async () =>
            {
                chkDateDebutContrat.IsValid = false;
                string idSoumissionnaire = Request.QueryString["IdentifiantMailing"];
                VueSoumissionnaire soumissionnaireMV = await PortailData.GetVueSoumissionnaireAsync($"api/VueSoumissionnaires/{idSoumissionnaire}");
                args.IsValid = false;
                DateTime dateDebutContratInput;
                DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput);
                if (DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput))
                {
                    if (dateDebutContratInput < soumissionnaireMV.DateEntreeBeneficiaire)
                    {
                        chkDateDebutContrat.IsValid = false;
                    }
                    else
                    {
                        chkDateDebutContrat.IsValid = true;
                        
                    }
                }
                else
                {
                    chkDateDebutContrat.IsValid = false;
                }
            }));
            Page.ExecuteRegisteredAsyncTasks();
        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Response.Redirect("Remerciements");
                Page.RegisterAsyncTask(new PageAsyncTask(PostReponse));
            }
        }
        private async Task PostReponse()
        {
            try
            {
                string idExercerFonction = Request.QueryString["IdentifiantMailing"];
                //Soumissionnaire soumissionnaire = await PortailData.GetSoumissionnaireAsync($"api/Soumissionnaires/{idSoumissionnaire}");
                //soumissionnaire.DateEnregistrementReponse = DateTime.Now;
                //soumissionnaire.ReponseEmploi = false;
                ExercerFonction exercerFonction = new ExercerFonction();
                //exercerFonction.IdentifiantMailingNavigation = await PortailData.GetSoumissionnaireAsync($"api/Soumissionnaires/{idExercerFonction}");
                exercerFonction.IdentifiantMailing = Guid.Parse(idExercerFonction);
                exercerFonction.IdtypeContrat = int.Parse(typecontrat.SelectedItem.Value);
                exercerFonction.DureeContrat = rdBtnListDuree.SelectedValue;
                exercerFonction.CodeAppellationRome = int.Parse(codeRome.Value);
                exercerFonction.DateEntreeFonction = DateTime.Parse(dateDebutContrat.Value);
                exercerFonction.DateSortieFonction = TryParse(dateFinContrat.Value);
                exercerFonction.DateReponse = DateTime.Now;
                //exercerFonction.IdentifiantMailingNavigation.DateEnregistrementReponse = DateTime.Now;
                //exercerFonction.IdentifiantMailingNavigation.ReponseEmploi = true;
                HttpResponseMessage reponse = await PortailData.PostExercerFonctionAsync($"api/ExercerFonctions", exercerFonction);
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
        private DateTime? TryParse(string text)
        {
            DateTime date;
            if (DateTime.TryParse(text, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }
    }
}