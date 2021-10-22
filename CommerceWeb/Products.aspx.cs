using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommerceWeb
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string test = Request.QueryString["productId"];
            //string test = Request.QueryString["categoryId"];
            Page.RegisterAsyncTask(new PageAsyncTask(async () =>
            {

                repProduct.DataSource = JsonConvert.DeserializeObject(await CommerceDAL.Instance.GetProductsAsync(Request.QueryString["categoryId"]));
                //stringToRead = await CommerceDAL.Instance.GetProductAsync("api/Categories");
                //Response.Write(stringToRead);


                repProduct.DataBind();
            }));
            Page.ExecuteRegisteredAsyncTasks();

        }
        protected void Pre_Init(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static String SetName(string name)
        {
            return "Your String";
        }
    }
}
 