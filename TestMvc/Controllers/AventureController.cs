using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestMvc.Core.Data;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.Titre = "Aventures";
            //this.ViewBag.Tab = new int[] {1,2,3,4,5 };
            List<Aventure> maList = new List<Aventure>();
            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "Ma premiere aventure"
            });
            maList.Add(new Aventure() 
            { 
                Id = 2, 
                Titre = "Ma seconde aventure" 
            });
            return View(maList);
        }
    }
}
