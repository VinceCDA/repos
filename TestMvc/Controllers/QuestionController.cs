using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestMvc.Core.Data;
using TestMvc.Core.Data.Models;

namespace TestMvc.Controllers
{
    public class QuestionController : Controller
    {
        private DefaultContext _context = null;

        public QuestionController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            this.ViewBag.PragrapheList = this._context.Paragraphes.ToList();
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(Question question)
        {
            this.ViewBag.PragrapheList = this._context.Paragraphes.ToList();
            if (this.ModelState.IsValid)
            {
                this._context.Questions.Add(question); 
                this._context.SaveChanges();
            }
            return View(question);
        }
    }
}
