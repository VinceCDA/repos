using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestMvc.Core.Data;
using TestMvc.Core.Data.Models;
using TestMvc.Models;
using System.Linq;

namespace TestMvc.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;
        public AventureController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            this.ViewBag.Titre = "Aventures";
            //this.ViewBag.Tab = new int[] {1,2,3,4,5 };
            List<Aventure> maList = new List<Aventure>();
            var query = from item in _context.Aventures
                        select item;
                        
            return View(query.ToList());
        }
    }
}
