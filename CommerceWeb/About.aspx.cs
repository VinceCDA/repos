﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommerceWeb
{
    public partial class About : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Task<string> T1 = null;
            //string test = "";
            //try
            //{
            //    T1 = GetProductAsync("https://localhost:44340/api/Categories");
            //    T1.Wait();
            //    if (T1.IsCompleted)
            //    {
            //        test = T1.Result;
            //    }
            //    if (T1.IsFaulted)
            //    {
            //        test = "toto";
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //   var test = GetProductAsync("http://loaclahost/api/Categories");
            //Response.Write(test);
            //var task = CommerceDAL.Instance.GetProductAsync("api/Categories");
            //task.Wait();
            //Response.Write(await CommerceDAL.Instance.GetProductAsync("api/Categories/5"));
            //var test = await CommerceDAL.Instance.GetProductAsync("api/Categories/5");
            //RegisterAsyncTask(new PageAsyncTask(() => CommerceDAL.Instance.GetProductAsync("api/Categories/5").Result));
            //Page.ExecuteRegisteredAsyncTasks();
        }

        //client.BaseAddress = new Uri("http://localhost:44340/");
        //client.DefaultRequestHeaders.Accept.Clear();
        //client.DefaultRequestHeaders.Accept.Add(
        //    new MediaTypeWithQualityHeaderValue("application/json"));
        //var stringTask = await client.GetStringAsync(path);

        //HttpResponseMessage response = await client.GetAsync(path);
        //if (response.IsSuccessStatusCode)
        //{
        //    return await response.Content.ReadAsStringAsync();
        //}

        //else
        //{
        //  return await Task.FromResult("error");
        //}
        protected async void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write(await CommerceDAL.Instance.GetProductAsync("api/Categories/5"));
            var test = await CommerceDAL.Instance.GetProductAsync("api/Categories/5");
        }





    }
}