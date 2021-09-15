using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class LireCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var item in Request.Cookies.AllKeys)
            {
                HttpCookie cookieTest = Request.Cookies[item];
                if (cookieTest.HasKeys)
                {
                    for (int i = 0; i < cookieTest.Values.Count; i++)
                    {
                        Response.Write($"Key : {cookieTest.Values.AllKeys[i]}" + $"Value : {cookieTest.Values[i]}<br />");
                    }
                }
                
            }
        }
    }
}