using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication02
{
    public partial class AppSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Début Application :" + Application["appStartTime"].ToString());
            Response.Write("Date Session Start :" + Session["sessionStart"].ToString());
            Response.Write("Date 1st Request :" + Context.Items["firstRequest"].ToString());
            //Application["nbRequest"] = int.Parse(Application["nbRequest"].ToString()) + 1;
            Response.Write("Nb Request :" + Application["nbRequest"].ToString());
            
        }
    }
}