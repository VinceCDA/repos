using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommerceWeb
{
    public partial class SiteMaster : MasterPage
    {
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
    }
}