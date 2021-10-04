using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnqueteAFPANA_API.Models;
using EnqueteAFPANA_API.DTO;

namespace EnqueteAFPANA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppellationRomesController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public AppellationRomesController(EnquetesContext context)
        {
            _context = context;
        }

        // GET: api/AppellationRomes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppellationRomeDTO>>> GetAppellationRomes()
        {
            return await _context.AppellationRomes.Select(x => new AppellationRomeDTO { LibelleAppellationRome = x.LibelleAppellationRome, CodeRome = x.CodeRome }).ToListAsync();
            //return await _context.AppellationRomes.ToListAsync();
        }

        // GET: api/AppellationRomes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppellationRome>> GetAppellationRome(int id)
        {
            var appellationRome = await _context.AppellationRomes.FindAsync(id);

            if (appellationRome == null)
            {
                return NotFound();
            }

            return appellationRome;
        }

        // PUT: api/AppellationRomes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppellationRome(int id, AppellationRome appellationRome)
        {
            if (id != appellationRome.CodeAppellationRome)
            {
                return BadRequest();
            }

            _context.Entry(appellationRome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppellationRomeExists(id))
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

        // POST: api/AppellationRomes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppellationRome>> PostAppellationRome(AppellationRome appellationRome)
        {
            _context.AppellationRomes.Add(appellationRome);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AppellationRomeExists(appellationRome.CodeAppellationRome))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAppellationRome", new { id = appellationRome.CodeAppellationRome }, appellationRome);
        }



        private bool AppellationRomeExists(int id)
        {
            return _context.AppellationRomes.Any(e => e.CodeAppellationRome == id);
        }
    }
}
