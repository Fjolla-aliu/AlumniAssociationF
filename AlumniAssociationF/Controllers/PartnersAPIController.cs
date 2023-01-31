using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlumniAssociationF.Data;
using AlumniAssociationF.Models;

namespace AlumniAssociationF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PartnersAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PartnersAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partners>>> GetPartners()
        {
            return await _context.Partners.ToListAsync();
        }

        // GET: api/PartnersAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partners>> GetPartners(int id)
        {
            var partners = await _context.Partners.FindAsync(id);

            if (partners == null)
            {
                return NotFound();
            }

            return partners;
        }

        // PUT: api/PartnersAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartners(int id, Partners partners)
        {
            if (id != partners.Id)
            {
                return BadRequest();
            }

            _context.Entry(partners).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartnersExists(id))
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

        // POST: api/PartnersAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Partners>> PostPartners(Partners partners)
        {
            _context.Partners.Add(partners);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartners", new { id = partners.Id }, partners);
        }

        // DELETE: api/PartnersAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartners(int id)
        {
            var partners = await _context.Partners.FindAsync(id);
            if (partners == null)
            {
                return NotFound();
            }

            _context.Partners.Remove(partners);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PartnersExists(int id)
        {
            return _context.Partners.Any(e => e.Id == id);
        }
    }
}
