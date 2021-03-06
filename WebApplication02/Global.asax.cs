using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;


namespace WebApplication02
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code qui s’exécute au démarrage de l’application
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["appStartTime"] = DateTime.Now;
            Application["nbRequest"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["sessionStart"] = DateTime.Now;
        }
        void Application_BeginRequest(object sender, EventArgs e)
        {
            Context.Items["firstRequest"] = DateTime.Now;
            Application["nbRequest"] = int.Parse(Application["nbRequest"].ToString()) + 1;

        }
        private void Application_Error(object sender, EventArgs e)
        {
            var ex = Server.GetLastError();
            var httpException = ex.InnerException as HttpException;
            if (httpException == null) return;

            if (httpException.WebEventCode == WebEventCodes.RuntimeErrorPostTooLarge)
            {
                //handle the error
                Response.Redirect("FileUpload.aspx");
                Response.Write("Sorry, file is too big"); //show this message for instance
            }
        }
    }

}