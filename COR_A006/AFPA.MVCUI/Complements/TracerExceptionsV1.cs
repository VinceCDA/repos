using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AFPA.MVCUI.Complements
{
    /// <summary>
    /// Traceur d'exception dans le journal des événements de l'application
    /// </summary>
    /// 
       
    public class TracerExceptionsV1 : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string message = ExtraireMessage(filterContext.Exception);
            LoggerExceptions(filterContext, message);
        }
        
        private string ExtraireMessage(Exception exception)
        {
            Exception innerExc = exception;

            while (innerExc.InnerException != null)
            {
                innerExc = innerExc.InnerException;
            }
            return innerExc.Message;
        }

        private void LoggerExceptions(ControllerContext contexte, string messageException)
        {
            string controleur = contexte.RouteData.Values["Controller"].ToString();
            string action = contexte.RouteData.Values["Action"].ToString();
            string message = string.Format("Contrôleur : {0}\nAction : {1}\nException : {2}",
                controleur,
                action,
                messageException);
            Journal.EcrireEvenement(message);
        }
    }
}
