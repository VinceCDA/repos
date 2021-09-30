using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using ECommerceAPPWeb.DataAPI;
using Newtonsoft.Json;
using NopCommerceBOL;

namespace ECommerceAPPWeb.Handlers
{
    public class HandlerPanier : IHttpHandler,IRequiresSessionState
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string action = context.Request.QueryString["action"].ToString();
            switch (action)
            {
                case "add":
                    int.TryParse(context.Request.QueryString["id"], out int productId);
                    ajouterProduit(context, productId);
                    break;
                default:
                    break;
            }

        }
        private void ajouterProduit(HttpContext context, int idProduit)
        {
            ProductAbr produit = PortailData.GetProductAsync($"api/products/produitAbr/{idProduit}").Result;
            Panier panier = getPanierSession(context);
            Panier.Ligne ligne = new Panier.Ligne(idProduit, produit.Name, produit.Price, 1);
            panier.Add(ligne);
            context.Request.ContentType = "application/json";
            context.Response.Write(JsonConvert.SerializeObject(produit));
            context.Response.End();
        }

        internal Panier getPanierSession(HttpContext context)
        {
            if (context.Session["monPanier"] == null)
            {
                context.Session["monPanier"] = new Panier();
            }
            return context.Session["monPanier"] as Panier;

        }
    }
}