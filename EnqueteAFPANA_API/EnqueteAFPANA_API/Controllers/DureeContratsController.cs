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
    public class DureeContratsController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public DureeContratsController(EnquetesContext context)
        {
            _context = context;
        }

        // GET: api/DureeContrats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DureeContrat>>> GetDureeContrats()
        {
            return await _context.DureeContrats.ToListAsync();
        }

        // GET: api/DureeContrats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DureeContrat>> GetDureeContrat(string id)
        {
            var dureeContrat = await _context.DureeContrats.FindAsync(id);

            if (dureeContrat == null)
            {
                return NotFound();
            }

            return dureeContrat;
        }

        // PUT: api/DureeContrats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDureeContrat(string id, DureeContrat dureeContrat)
        {
            if (id != dureeContrat.IdDureeContrat)
            {
                return BadRequest();
            }

            _context.Entry(dureeContrat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DureeContratExists(id))
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

        // POST: api/DureeContrats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DureeContrat>> PostDureeContrat(DureeContrat dureeContrat)
        {
            _context.DureeContrats.Add(dureeContrat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DureeContratExists(dureeContrat.IdDureeContrat))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDureeContrat", new { id = dureeContrat.IdDureeContrat }, dureeContrat);
        }

        // DELETE: api/DureeContrats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDureeContrat(string id)
        {
            var dureeContrat = await _context.DureeContrats.FindAsync(id);
            if (dureeContrat == null)
            {
                return NotFound();
            }

            _context.DureeContrats.Remove(dureeContrat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DureeContratExists(string id)
        {
            return _context.DureeContrats.Any(e => e.IdDureeContrat == id);
        }
    }
}
