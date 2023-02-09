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
    public class CentersAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CentersAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CentersAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Center>>> GetCenter()
        {
            return await _context.Center.ToListAsync();
        }

        // GET: api/CentersAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Center>> GetCenter(int id)
        {
            var center = await _context.Center.FindAsync(id);

            if (center == null)
            {
                return NotFound();
            }

            return center;
        }

        // PUT: api/CentersAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCenter(int id, Center center)
        {
            if (id != center.Id)
            {
                return BadRequest();
            }

            _context.Entry(center).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CenterExists(id))
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

        // POST: api/CentersAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Center>> PostCenter(Center center)
        {
            _context.Center.Add(center);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCenter", new { id = center.Id }, center);
        }

        // DELETE: api/CentersAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCenter(int id)
        {
            var center = await _context.Center.FindAsync(id);
            if (center == null)
            {
                return NotFound();
            }

            _context.Center.Remove(center);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CenterExists(int id)
        {
            return _context.Center.Any(e => e.Id == id);
        }
    }
}
