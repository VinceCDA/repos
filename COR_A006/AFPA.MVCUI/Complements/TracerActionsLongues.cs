using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AFPA.MVCUI.Complements
{
    public class TracerActionsLonguesAttribute : ActionFilterAttribute
    {
        ControllerContext contexteAction;
       
        DateTime debutAction;
        /// <summary>
        /// Durée minimale de l'action en secondes
        /// </summary>
        public double DureeMinimum { get; set; }
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            debutAction = DateTime.Now;
            
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            DateTime finAction = DateTime.Now;
            contexteAction = filterContext;
            
            CalculerDureeAction(finAction);
            
            base.OnActionExecuted(filterContext);
        }

        public void CalculerDureeAction(DateTime finAction)
        {
            double dureeAction = (finAction - debutAction).TotalMilliseconds;

            if (dureeAction / 1000.00 > this.DureeMinimum)
            {
                LoggerExceptions(contexteAction, dureeAction/1000.00);
            }
        }

        private void LoggerExceptions(ControllerContext contexte, double duree)
        {
            string controleur = contexte.RouteData.Values["Controller"].ToString();
            string action = contexte.RouteData.Values["Action"].ToString();
            string methode = contexte.HttpContext.Request.HttpMethod;
            string message = string.Format("Contrôleur : {0}\nAction : {1}\nMéthode HTTP : {2}\n Durée Mimimum Log {3}\n Durée de l'action : {4} secondes",
                controleur,
                action,
                methode,
                DureeMinimum,
                Math.Round(duree, 3));
            Journal.EcrireEvenement(message);
        }
    }
}
