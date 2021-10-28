using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestMvc.Core.Data;
using TestMvc.Core.Data.Models;

namespace TestMvc.Controllers
{
    public class ParagrapheController : Controller
    {
        private DefaultContext _context = null;

        public ParagrapheController(DefaultContext context)
        {
            _context = context; 
        }
        //private List<Paragraphe> _listPara = new List<Paragraphe>()
        //{
        //    new Paragraphe(){Id=1,Numero=1,Titre="Toto",Description="Descri para Toto"},
        //    new Paragraphe(){Id=2,Numero=11,Titre="Titi",Description="Descri para Titi"},
        //    new Paragraphe(){Id=3,Numero=24,Titre="Tata",Description="Descri para Tata"},
        //    new Paragraphe(){Id=4,Numero=50,Titre="Tutu",Description="Descri para Tutu"}
        //};
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            this._context.Paragraphes.Add(paragraphe); 
            this._context.SaveChanges();    
            return View();
        }
        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = new Paragraphe();
            paragraphe = _context.Paragraphes.First(a => a.Id == id);   
            return View(paragraphe);
        }
        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            //this._context.Attach<Paragraphe>(paragraphe);
            //this._context.Entry(paragraphe).Property(e => e.Titre).IsModified = true;
            _context.Paragraphes.Update(paragraphe);
            _context.SaveChanges();
            return View();
        }
    }
}
