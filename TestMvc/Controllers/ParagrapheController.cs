using Microsoft.AspNetCore.Mvc;
using TestMvc.Core.Data.Models;

namespace TestMvc.Controllers
{
    public class ParagrapheController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }
    }
}
