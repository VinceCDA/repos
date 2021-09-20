using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;
using System.Xml.Linq;

namespace WebApplication02
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //XmlDataSource xmlDataSource = new XmlDataSource();
            //xmlDataSource.DataFile = @"C:\Users\CDA\source\repos\WebApplication02\Pays.XML";
            //this.selPays.DataSource = xmlDataSource;
            //this.selPays. = "userID";
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load(@"C:\Users\CDA\source\repos\WebApplication02\Pays.XML");
            //XmlNodeList elemList = xmlDocument.GetElementsByTagName("Pays");
            //selPays.DataSource = xmlDocument.DocumentElement.InnerText;
            //XElement listPays = XElement.Load(@"C:\Users\CDA\source\repos\WebApplication02\Pays.XML");
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(@"C:\Users\CDA\source\repos\WebApplication02\Pays.XML");
            //selPays.DataSource = XmlDataSource1.XPath = "Pays/LibellePays";
            //selPays.DataBind();
            //selPays.DataBind();
            //string filePath = Server.MapPath("~/Cities.xml");
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@"C:\Users\Kuroneko\Documents\GitHub\repos\WebApplication02\Pays.XML");
                selPays.DataSource = ds;
                selPays.DataTextField = "LibellePays";
                selPays.DataValueField = "IdPays2";
                selPays.DataBind();
            }
            
        }
        protected void Page_Preinit(object sender, EventArgs e)
        {
            HttpCookie cookieTest = Request.Cookies["prefs"];
            Page.Theme = cookieTest["theme"];
        }
    }
}