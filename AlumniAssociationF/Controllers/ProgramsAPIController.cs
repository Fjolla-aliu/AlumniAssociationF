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
    public class ProgramsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProgramsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProgramsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumniAssociationF.Models.Program>>> GetPrograms()
        {
            return await _context.Programs.ToListAsync();
        }

        // GET: api/ProgramsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlumniAssociationF.Models.Program>> GetProgram(int id)
        {
            var program = await _context.Programs.FindAsync(id);

            if (program == null)
            {
                return NotFound();
            }

            return program;
        }

        // PUT: api/ProgramsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgram(int id, AlumniAssociationF.Models.Program program)
        {
            if (id != program.Id)
            {
                return BadRequest();
            }

            _context.Entry(program).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramExists(id))
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

        // POST: api/ProgramsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlumniAssociationF.Models.Program>> PostProgram(AlumniAssociationF.Models.Program program)
        {
            _context.Programs.Add(program);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgram", new { id = program.Id }, program);
        }

        // DELETE: api/ProgramsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgram(int id)
        {
            var program = await _context.Programs.FindAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            _context.Programs.Remove(program);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgramExists(int id)
        {
            return _context.Programs.Any(e => e.Id == id);
        }
    }
}
