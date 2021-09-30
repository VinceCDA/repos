using Newtonsoft.Json;
using NopCommerceBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ECommerceAPPWeb.DataAPI
{

    public static class PortailData
    {
        static public readonly HttpClient httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44320/") };
        static public async Task<List<Category>> GetCategoriesAsync(string path)
        {
            List<Category> categories = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                categories = JsonConvert.DeserializeObject<List<Category>>(
                 await response.Content.ReadAsStringAsync());
            }
            return categories;
        }
        static public async Task<List<ProductAbr>> GetProductsAsync(string path)
        {
            List<ProductAbr> products = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                products = JsonConvert.DeserializeObject<List<ProductAbr>>(
                 await response.Content.ReadAsStringAsync());
            }
            return products;
        }
        static public async Task<List<Category>> GetCategoriesPrincipalesAsync(string path)
        {
            List<Category> categories = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                categories = JsonConvert.DeserializeObject<List<Category>>(
                 await response.Content.ReadAsStringAsync());
            }
            return categories;
        }
        static public async Task<ProductAbr> GetProductAsync(string path)
        {
            ProductAbr product = null;
            HttpResponseMessage response = await httpClient.GetAsync(path).ConfigureAwait(continueOnCapturedContext: false);
            if (response.IsSuccessStatusCode)
            {
                product = JsonConvert.DeserializeObject<ProductAbr>(
                 await response.Content.ReadAsStringAsync());
            }
            return product;
        }
    }
}