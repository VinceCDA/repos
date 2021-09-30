using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CommerceWeb
{
    public partial class Index : System.Web.UI.Page

    {
        DataTable dataSetCat = new DataTable();
        string stringToRead = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.RegisterAsyncTask(new PageAsyncTask(async () =>
            {

                repCategory.DataSource = JsonConvert.DeserializeObject(await CommerceDAL.Instance.GetProductAsync("api/Categories"));
                //stringToRead = await CommerceDAL.Instance.GetProductAsync("api/Categories");
                //Response.Write(stringToRead);


                repCategory.DataBind();
            }));
            Page.ExecuteRegisteredAsyncTasks();
            
            
        }
        protected void Pre_Init(object sender, EventArgs e)
        {
           
        }
    }
}