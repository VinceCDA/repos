using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace CommerceWeb
{
    public class CommerceDAL
    {
        public static string DbConnectionString { get; set; } = null;
        private static CommerceDAL _instance = null;

        private static readonly object _verrou = new object();
        public static CommerceDAL Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new CommerceDAL();
                    }
                }
                return _instance;
            }
        }

        public static HttpClient Client = new HttpClient();

        public void GetHttpClient()
        {
            Client.BaseAddress = new Uri(Properties.Settings.Default.ApiConnectionString);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<string> GetProductAsync(string path)
        {
            var result = await Client.GetAsync(path);
            return await result.Content.ReadAsStringAsync();

        }
        public async Task<string> GetProductPictureAsync(string path)
        {
            var result = Client.BaseAddress.ToString() + $"api/Pictures/{path}";
            return result;

        }
        public async Task<string> GetProductsAsync(string path)
        {
            //var result = await Client.GetAsync(path);
            var result = await Client.GetAsync($"api/ProductCategoryMappings/{path}");
            return await result.Content.ReadAsStringAsync();

        }

    }
}