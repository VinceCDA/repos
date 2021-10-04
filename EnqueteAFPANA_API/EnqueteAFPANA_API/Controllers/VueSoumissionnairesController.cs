using EnqueteAFPANA_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnqueteAFPANA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueSoumissionnairesController : ControllerBase
    {
        private readonly EnquetesContext _context;

        public VueSoumissionnairesController(EnquetesContext context)
        {
            _context = context;
        }
        // GET: api/<VueSoumissionnairesController>
        

        // GET api/<VueSoumissionnairesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VueSoumissionnaire>> Get(Guid id)
        {
            var soumissionnaire = await  _context.VueSoumissionnaires.Where(s=>s.IdentifiantMailing==id).FirstOrDefaultAsync();
            if (soumissionnaire == null)
            {
                return NotFound();
            }

            return soumissionnaire;
        }

        // POST api/<VueSoumissionnairesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VueSoumissionnairesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VueSoumissionnairesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
