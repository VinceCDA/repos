using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}