using Newtonsoft.Json;
using EnquetesAFPANA_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Text;

namespace EnquetesAFPANA_WebApp.DataAPI
{

    public static class PortailData
    {
        static public readonly HttpClient httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44327/") };
        static public async Task<List<Soumissionnaire>> GetSoumissionnairesNoRepAsync(string path)
        {
            List<Soumissionnaire> soumissionnaires = null;
            HttpResponseMessage response = await httpClient.GetAsync(path).ConfigureAwait(continueOnCapturedContext: false); 
            if (response.IsSuccessStatusCode)
            {
                soumissionnaires = JsonConvert.DeserializeObject<List<Soumissionnaire>>(
                 await response.Content.ReadAsStringAsync());
            }
            return soumissionnaires;
        }
        static public async Task<VueSoumissionnaire> GetVueSoumissionnaireAsync(string path)
        {
            VueSoumissionnaire soumissionnaire = null;
            HttpResponseMessage response = await httpClient.GetAsync(path).ConfigureAwait(continueOnCapturedContext: false);
            if (response.IsSuccessStatusCode)
            {
                soumissionnaire = JsonConvert.DeserializeObject<VueSoumissionnaire>(
                 await response.Content.ReadAsStringAsync());
            }
            return soumissionnaire;
        }
        static public async Task<Soumissionnaire> GetSoumissionnaireAsync(string path)
        {
            Soumissionnaire soumissionnaire = null;
            HttpResponseMessage response = await httpClient.GetAsync(path).ConfigureAwait(continueOnCapturedContext: false);
            if (response.IsSuccessStatusCode)
            {
                soumissionnaire = JsonConvert.DeserializeObject<Soumissionnaire>(
                 await response.Content.ReadAsStringAsync());
            }
            return soumissionnaire;
        }
        static public async Task<HttpResponseMessage> PutSoumissionnaireAsync(string path, Soumissionnaire soumissionnaire)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(soumissionnaire), Encoding.UTF8, "application/json");
            return await httpClient.PutAsync(path, content);
        }
        static public async Task<string> GetTypeContratListAsync()
        {
            var result = await httpClient.GetAsync("api/TypeContrats");
            return await result.Content.ReadAsStringAsync();

        }
        static public async Task<string> GetDureeContratListAsync()
        {
            var result = await httpClient.GetAsync("api/DureeContrats");
            return await result.Content.ReadAsStringAsync();

        }

    }
}