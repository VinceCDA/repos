using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NopCommerceBOL;
using NopCommerceDAL;
using NOPAPIRest.ModelViews;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NOPAPIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ECommerceSimplifieContext _context;

        public ProductsController(ECommerceSimplifieContext context)
        {
            _context = context;
        }
        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
      
        // GET: api/products/
        [HttpGet]
        [Route("categoryId/{idCategory}/{pageNum}/{pageSize}")]
        public async Task<ActionResult<IEnumerable<ProductAbr>>> GetProductsByCategory(int idCategory,int pageNum,int pageSize)
        {
            return await (from pcm in _context.ProductCategoryMappings
                            join prod in _context.Products on pcm.ProductId equals prod.Id
                            join ppm in _context.ProductPictureMappings on prod.Id equals ppm.ProductId
                            where (pcm.CategoryId == idCategory && ppm.DisplayOrder == 1)
                            select new ProductAbr
                            {
                                Id=prod.Id,
                                DisplayOrder = prod.DisplayOrder,
                                FullDescription = prod.FullDescription,
                                Name = prod.Name,
                                PictureId = ppm.PictureId,
                                Price = prod.Price,
                                ShortDescription = prod.ShortDescription
                            }).OrderBy(o => o.DisplayOrder).Skip((pageNum - 1) * pageSize).Take(pageSize).ToListAsync();
           }


       

        // GET: api/Products/5
        [HttpGet]
        [Route("produitAbr/{id}")]
        public async Task<ActionResult<ProductAbr>> GetProduct(int id)
        {
            ProductAbr product = await (from prod in _context.Products
                                  join ppm in _context.ProductPictureMappings on prod.Id equals ppm.ProductId
                                  where (prod.Id == id && ppm.DisplayOrder == 1)
                                  select new ProductAbr
                                  {
                                      Id = prod.Id,
                                      DisplayOrder = prod.DisplayOrder,
                                      FullDescription = prod.FullDescription,
                                      Name = prod.Name,
                                      PictureId = ppm.PictureId,
                                      Price = prod.Price,
                                      ShortDescription = prod.ShortDescription
                                  }).FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

    }
}
