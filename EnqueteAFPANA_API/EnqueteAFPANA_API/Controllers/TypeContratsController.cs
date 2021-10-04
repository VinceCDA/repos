using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnqueteAFPANA_API.Models;

namespace EnqueteAFPANA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeContratsController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public TypeContratsController(EnquetesContext context)
        {
            _context = context;
        }

        // GET: api/TypeContrats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeContrat>>> GetTypeContrats()
        {
            return await _context.TypeContrats.ToListAsync();
        }

        // GET: api/TypeContrats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeContrat>> GetTypeContrat(int id)
        {
            var typeContrat = await _context.TypeContrats.FindAsync(id);

            if (typeContrat == null)
            {
                return NotFound();
            }

            return typeContrat;
        }

        // PUT: api/TypeContrats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeContrat(int id, TypeContrat typeContrat)
        {
            if (id != typeContrat.IdtypeContrat)
            {
                return BadRequest();
            }

            _context.Entry(typeContrat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeContratExists(id))
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

        // POST: api/TypeContrats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeContrat>> PostTypeContrat(TypeContrat typeContrat)
        {
            _context.TypeContrats.Add(typeContrat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TypeContratExists(typeContrat.IdtypeContrat))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTypeContrat", new { id = typeContrat.IdtypeContrat }, typeContrat);
        }

        // DELETE: api/TypeContrats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeContrat(int id)
        {
            var typeContrat = await _context.TypeContrats.FindAsync(id);
            if (typeContrat == null)
            {
                return NotFound();
            }

            _context.TypeContrats.Remove(typeContrat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeContratExists(int id)
        {
            return _context.TypeContrats.Any(e => e.IdtypeContrat == id);
        }
    }
}
