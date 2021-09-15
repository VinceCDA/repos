using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class TestCookie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 
                HttpCookie cookie = new HttpCookie("AcceptCookie");
                cookie.Value = "true";
                Response.Cookies.Add(cookie);
                Response.Redirect("TestCookie2.aspx");
            }
        }
    }
}