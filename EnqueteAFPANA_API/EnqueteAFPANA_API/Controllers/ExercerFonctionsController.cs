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
    public class ExercerFonctionsController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public ExercerFonctionsController(EnquetesContext context)
        {
            _context = context;
        }

        // GET: api/ExercerFonctions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExercerFonction>>> GetExercerFonctions()
        {
            return await _context.ExercerFonctions.ToListAsync();
        }

        // GET: api/ExercerFonctions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExercerFonction>> GetExercerFonction(int id)
        {
            var exercerFonction = await _context.ExercerFonctions.FindAsync(id);

            if (exercerFonction == null)
            {
                return NotFound();
            }

            return exercerFonction;
        }

        // PUT: api/ExercerFonctions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExercerFonction(Guid id, ExercerFonction exercerFonction)
        {
            if (id != exercerFonction.IdentifiantMailing)
            {
                return BadRequest();
            }

            _context.Entry(exercerFonction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExercerFonctionExists(id))
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

        // POST: api/ExercerFonctions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExercerFonction>> PostExercerFonction(ExercerFonction exercerFonction)
        {
            _context.ExercerFonctions.Add(exercerFonction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercerFonction", new { id = exercerFonction.IdExercerFonction }, exercerFonction);
        }

        // DELETE: api/ExercerFonctions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercerFonction(int id)
        {
            var exercerFonction = await _context.ExercerFonctions.FindAsync(id);
            if (exercerFonction == null)
            {
                return NotFound();
            }

            _context.ExercerFonctions.Remove(exercerFonction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExercerFonctionExists(Guid id)
        {
            return _context.ExercerFonctions.Any(e => e.IdentifiantMailing == id);
        }
    }
}
