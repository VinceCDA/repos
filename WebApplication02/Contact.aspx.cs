using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication02
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Preinit(object sender, EventArgs e)
        {
            HttpCookie cookieTest = Request.Cookies["prefs"];
            Page.Theme = cookieTest["theme"];
        }
    }
}