using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommerceAPI.Models;

namespace CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPictureMappingsController : ControllerBase
    {
        private readonly EcommerceSimplifieContext _context;

        public ProductPictureMappingsController(EcommerceSimplifieContext context)
        {
            _context = context;
        }

        // GET: api/ProductPictureMappings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPictureMapping>>> GetProductPictureMappings()
        {
            return await _context.ProductPictureMappings.ToListAsync();
        }

        // GET: api/ProductPictureMappings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPictureMapping>> GetProductPictureMapping(int id)
        {
            //var productPictureMapping = await _context.ProductPictureMappings.FindAsync(id);

            //var productPictureMapping = await _context.ProductPictureMappings.Where(x => x.ProductId == id).FirstAsync();
            //var productPictureMapping = await (from x in _context.ProductPictureMappings
            //                                   join y in _context.Products on x.ProductId equals y.Id
            //                                   join t in _context.Pictures on x.PictureId equals t.Id
            //                                   where x.ProductId == id
            //                                   group x by x.ProductId).FirstAsync();
            //var productPictureMapping = await _context.ProductPictureMappings.Include(x => x.Product).Include(y => y.Picture).FirstAsync();
            //productPictureMapping.Product = await _context.Products.FindAsync(id);
            //var product = await _context.Products.FindAsync(id);
            // var picture = await _context.Pictures.FindAsync(productPictureMapping.PictureId);
            //productPictureMapping.Picture = picture;
            //productPictureMapping.Product = product;
            var productPictureMapping = await _context.ProductPictureMappings.Include("Picture").Include("Product").FirstOrDefaultAsync(x => x.ProductId == id);
            
            if (productPictureMapping == null)
            {
                return NotFound();
            }
            //productPictureMapping.Picture.PictureBinary = null;
            return productPictureMapping;
        }

        // PUT: api/ProductPictureMappings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPictureMapping(int id, ProductPictureMapping productPictureMapping)
        {
            if (id != productPictureMapping.Id)
            {
                return BadRequest();
            }

            _context.Entry(productPictureMapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPictureMappingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductPictureMappings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPictureMapping>> PostProductPictureMapping(ProductPictureMapping productPictureMapping)
        {
            _context.ProductPictureMappings.Add(productPictureMapping);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPictureMapping", new { id = productPictureMapping.Id }, productPictureMapping);
        }

        // DELETE: api/ProductPictureMappings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPictureMapping(int id)
        {
            var productPictureMapping = await _context.ProductPictureMappings.FindAsync(id);
            if (productPictureMapping == null)
            {
                return NotFound();
            }

            _context.ProductPictureMappings.Remove(productPictureMapping);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPictureMappingExists(int id)
        {
            return _context.ProductPictureMappings.Any(e => e.Id == id);
        }
    }
}
