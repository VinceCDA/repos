using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication02
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Preinit(object sender, EventArgs e)
        {
            
            
                HttpCookie cookieTest = Request.Cookies["prefs"];
                if (cookieTest == null)
                {
                    Page.Theme = "";
                }
                else
                {
                    Page.Theme = cookieTest["theme"];
                }
            
            
            
        }
    }
}