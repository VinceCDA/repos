using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class WebFormA002 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack)
            {
                
                
            }
        }

        protected void txtNom_ServerChange(object sender, EventArgs e)
        {
            Response.Write("Postaback");
        }
        protected void txtNom_OnChange(object sender, EventArgs e)
        {
            
        }
    }
}