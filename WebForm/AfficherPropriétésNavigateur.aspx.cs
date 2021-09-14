using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class AfficherPropriétésNavigateur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpBrowserCapabilities browserCapabilities = Request.Browser;
            txtNav.Text = browserCapabilities.Browser;
            txtNavVer.Text = browserCapabilities.Version;
            txtCookies.Text = browserCapabilities.Cookies.ToString();
            txtJs.Text = browserCapabilities.EcmaScriptVersion.ToString();
            txtActiveX.Text = browserCapabilities.ActiveXControls.ToString();

        }
    }
}