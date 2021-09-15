using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class TestCookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div1.Visible = false;
            div2.Visible = false;
            HttpCookie cookieTest = Request.Cookies["AcceptCookie"];
            if (cookieTest == null)
            {
                div2.Visible = true;
                div2.InnerText = "Cookie introuvable";
            }
            else
            {
                div1.Visible = true;
                //div1.InnerText = "Cookie trouvé";
                Response.Write("Cookie trouvé");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Infos");
            cookie.Values.Add("nom", txtNom.Text);
            cookie.Values.Add("address", txtPrenom.Text);
            cookie.Values.Add("dateConnexion", DateTime.Now.ToString());
            //cookie.Path = "/Webform";
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
        }
    }
}