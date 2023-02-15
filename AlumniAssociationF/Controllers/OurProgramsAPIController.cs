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
    public class OurProgramsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OurProgramsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/OurProgramsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OurProgram>>> GetOurProgram()
        {
            return await _context.OurProgram.ToListAsync();
        }

        // GET: api/OurProgramsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OurProgram>> GetOurProgram(int id)
        {
            var ourProgram = await _context.OurProgram.FindAsync(id);

            if (ourProgram == null)
            {
                return NotFound();
            }

            return ourProgram;
        }

        // PUT: api/OurProgramsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOurProgram(int id, OurProgram ourProgram)
        {
            if (id != ourProgram.Id)
            {
                return BadRequest();
            }

            _context.Entry(ourProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OurProgramExists(id))
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

        // POST: api/OurProgramsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OurProgram>> PostOurProgram(OurProgram ourProgram)
        {
            _context.OurProgram.Add(ourProgram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOurProgram", new { id = ourProgram.Id }, ourProgram);
        }

        // DELETE: api/OurProgramsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOurProgram(int id)
        {
            var ourProgram = await _context.OurProgram.FindAsync(id);
            if (ourProgram == null)
            {
                return NotFound();
            }

            _context.OurProgram.Remove(ourProgram);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OurProgramExists(int id)
        {
            return _context.OurProgram.Any(e => e.Id == id);
        }
    }
}
