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
                args.IsValid = false;
                string idSoumissionnaire = Request.QueryString["IdentifiantMailing"];
                VueSoumissionnaire soumissionnaireMV = await PortailData.GetVueSoumissionnaireAsync($"api/VueSoumissionnaires/{idSoumissionnaire}");
                DateTime dateDebutContratInput;
                DateTime? dateFinContratInput = TryParse(dateFinContrat.Value);
                DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput);
                if (DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput))
                {
                    
                    if (dateDebutContratInput > soumissionnaireMV.DateEntreeBeneficiaire)
                    {
                        args.IsValid = true;
                    }
                    else
                    {
                        args.IsValid = false;

                    }
                }
                else
                {
                    args.IsValid = false;
                }
            }));
            
            Page.ExecuteRegisteredAsyncTasks();
        }
        protected void ChkDateFinContrat_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            DateTime dateDebutContratInput;
            DateTime? dateFinContratInput = TryParse(dateFinContrat.Value);
            DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput);
            if (DateTime.TryParse(dateDebutContrat.Value, out dateDebutContratInput))
            {
                if (dateDebutContratInput < dateFinContratInput && dateFinContratInput != null)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            else
            {
                args.IsValid = false;
            }
        }
        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Response.Redirect("Remerciements");
                //Page.RegisterAsyncTask(new PageAsyncTask(PostReponse));
            }
        }
        private async Task PostReponse()
        {
            try
            {
                string idExercerFonction = Request.QueryString["IdentifiantMailing"];
                Soumissionnaire soumissionnaire = await PortailData.GetSoumissionnaireAsync($"api/Soumissionnaires/{idExercerFonction}");
                
                ExercerFonction exercerFonction = new ExercerFonction
                {
                    //exercerFonction.IdentifiantMailingNavigation = await PortailData.GetSoumissionnaireAsync($"api/Soumissionnaires/{idExercerFonction}");
                    //exercerFonction.IdentifiantMailing = Guid.Parse(idExercerFonction);
                    IdentifiantMailing = soumissionnaire.IdentifiantMailing,
                    IdtypeContrat = int.Parse(typecontrat.SelectedItem.Value),
                    DureeContrat = rdBtnListDuree.SelectedValue,
                    CodeAppellationRome = int.Parse(codeRome.Value),
                    DateEntreeFonction = DateTime.Parse(dateDebutContrat.Value),
                    DateSortieFonction = TryParse(dateFinContrat.Value),
                    DateReponse = DateTime.Now
                };
                //exercerFonction.IdentifiantMailingNavigation.DateEnregistrementReponse = DateTime.Now;
                //exercerFonction.IdentifiantMailingNavigation.ReponseEmploi = true;
                HttpResponseMessage reponse = await PortailData.PostExercerFonctionAsync($"api/ExercerFonctions", exercerFonction);
                if (reponse.IsSuccessStatusCode)
                {
                    soumissionnaire.DateEnregistrementReponse = DateTime.Now;
                    soumissionnaire.ReponseEmploi = true;
                    HttpResponseMessage putResponse = await PortailData.PutSoumissionnaireAsync($"api/Soumissionnaires/{idExercerFonction}", soumissionnaire);
                    //Response.Redirect("Remerciements.aspx");
                    if (putResponse.IsSuccessStatusCode)
                    {
                        Response.Redirect("Remerciements.aspx");
                    }
                    else
                    {
                        Response.Redirect("Erreur.aspx");
                    }
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