using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestMvc.Core.Data;
using TestMvc.Core.Data.Models;

namespace TestMvc.Controllers
{
    public class ReponseController : Controller
    {
        private DefaultContext _context = null;

        public ReponseController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            this.ViewBag.QuestionList = this._context.Questions.ToList();
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            
            if (this.ModelState.IsValid)
            {
                this._context.Reponses.Add(reponse);
                this._context.SaveChanges();
            }
            this.ViewBag.QuestionList = this._context.Questions.ToList();
            return View(reponse);
        }
    }
}
