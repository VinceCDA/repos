using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NopCommerceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NOPAPIRest.ModelViews;
using Microsoft.EntityFrameworkCore;
using NopCommerceBOL;

namespace NOPAPIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ECommerceSimplifieContext _context;

        public CategoriesController(ECommerceSimplifieContext context)
        {
            _context = context;
        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
        [HttpGet]
        [Route("Parent/{parentCategoryId}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategoriesParentes(int parentCategoryId)
        {
            return await _context.Categories.Where(c=>c.ParentCategoryId== parentCategoryId).ToListAsync();
        }
    }
}
