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
    public class SoumissionnairesController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public SoumissionnairesController(EnquetesContext context)
        {
            _context = context;
        }

        // GET: api/Soumissionnaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Soumissionnaire>>> GetSoumissionnaires()
        {
            return await _context.Soumissionnaires.ToListAsync();
        }
        [HttpGet]
        [Route("NoReponse")]
        public async Task<ActionResult<IEnumerable<Soumissionnaire>>> GetSoumissionnairesNoRep()
        {
            return await _context.Soumissionnaires.Where(s => s.ReponseEmploi==null).ToListAsync();
        }
        // GET: api/Soumissionnaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Soumissionnaire>> GetSoumissionnaire(Guid id)
        {
            var soumissionnaire = await _context.Soumissionnaires.FindAsync(id);

            if (soumissionnaire == null)
            {
                return NotFound();
            }

            return soumissionnaire;
        }

        // PUT: api/Soumissionnaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoumissionnaire(Guid id, Soumissionnaire soumissionnaire)
        {
            if (id != soumissionnaire.IdentifiantMailing)
            {
                return BadRequest();
            }

            _context.Entry(soumissionnaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoumissionnaireExists(id))
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

        // POST: api/Soumissionnaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Soumissionnaire>> PostSoumissionnaire(Soumissionnaire soumissionnaire)
        {
            _context.Soumissionnaires.Add(soumissionnaire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoumissionnaire", new { id = soumissionnaire.IdentifiantMailing }, soumissionnaire);
        }

        // DELETE: api/Soumissionnaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoumissionnaire(Guid id)
        {
            var soumissionnaire = await _context.Soumissionnaires.FindAsync(id);
            if (soumissionnaire == null)
            {
                return NotFound();
            }

            _context.Soumissionnaires.Remove(soumissionnaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SoumissionnaireExists(Guid id)
        {
            return _context.Soumissionnaires.Any(e => e.IdentifiantMailing == id);
        }
    }
}
