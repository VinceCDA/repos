using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication02
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieTest = Request.Cookies["prefs"];
            if (cookieTest["prefs"] == null)
            {
                HttpCookie cookie = new HttpCookie("prefs");
                cookie.Values.Add("theme", "");
                cookie.Values.Add("dateConnexion", DateTime.Now.ToString());
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
            }
            
            
        }


        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTheme.SelectedIndex != 0)
            {
                HttpCookie cookieTest = Request.Cookies["prefs"];
                cookieTest["theme"] = ddlTheme.Text;
                Response.Redirect(Request.RawUrl);
            }
            

        }
    }
}