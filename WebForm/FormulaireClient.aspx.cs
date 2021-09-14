using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class FormulaireClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (this.Request.RequestType)
            {
                case "GET":
                    NameValueCollection cles = Request.QueryString;
                    //NameValueCollection qscoll = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    for (int j = 0; j < cles.Count; j++)
                    {
                        TableRow r = new TableRow();
                        TableCell c = new TableCell();
                        TableCell c2 = new TableCell();
                        c2.Text = cles[j];
                        c.Text = cles.GetKey(j);
                        r.Cells.Add(c);
                        r.Cells.Add(c2);


                        Table1.Rows.Add(r);
                    }
                    break;
                case "POST":
                    NameValueCollection clesPost = Request.Form;
                    //NameValueCollection qscoll = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    for (int j = 0; j < clesPost.Count; j++)
                    {
                        TableRow r = new TableRow();
                        TableCell c = new TableCell();
                        TableCell c2 = new TableCell();
                        c2.Text = clesPost[j];
                        c.Text = clesPost.GetKey(j);
                        r.Cells.Add(c);
                        r.Cells.Add(c2);


                        Table1.Rows.Add(r);
                    }
                    break;

            }


        }

        protected void gridRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}