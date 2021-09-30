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
    public class ProductCategoryMappingsController : ControllerBase
    {
        private readonly EcommerceSimplifieContext _context;

        public ProductCategoryMappingsController(EcommerceSimplifieContext context)
        {
            _context = context;
        }

        // GET: api/ProductCategoryMappings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategoryMapping>>> GetProductCategoryMappings()
        {
            return await _context.ProductCategoryMappings.ToListAsync();
        }

        // GET: api/ProductCategoryMappings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ProductCategoryMapping>>> GetProductCategoryMapping(int id)
        {
            //var productCategoryMapping = await _context.ProductCategoryMappings.FindAsync(id);
            var productCategoryMapping = await _context.ProductCategoryMappings.Where(x => x.CategoryId == id).ToListAsync();

            if (productCategoryMapping == null)
            {
                return NotFound();
            }

            return productCategoryMapping;
        }

        // PUT: api/ProductCategoryMappings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductCategoryMapping(int id, ProductCategoryMapping productCategoryMapping)
        {
            if (id != productCategoryMapping.Id)
            {
                return BadRequest();
            }

            _context.Entry(productCategoryMapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoryMappingExists(id))
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

        // POST: api/ProductCategoryMappings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductCategoryMapping>> PostProductCategoryMapping(ProductCategoryMapping productCategoryMapping)
        {
            _context.ProductCategoryMappings.Add(productCategoryMapping);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCategoryMapping", new { id = productCategoryMapping.Id }, productCategoryMapping);
        }

        // DELETE: api/ProductCategoryMappings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductCategoryMapping(int id)
        {
            var productCategoryMapping = await _context.ProductCategoryMappings.FindAsync(id);
            if (productCategoryMapping == null)
            {
                return NotFound();
            }

            _context.ProductCategoryMappings.Remove(productCategoryMapping);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductCategoryMappingExists(int id)
        {
            return _context.ProductCategoryMappings.Any(e => e.Id == id);
        }
    }
}
