using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlumniAssociationF.Data;
using AlumniAssociationF.Models;
using Microsoft.AspNetCore.Authorization;

namespace AlumniAssociationF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentisAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentisAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentisAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studenti>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/StudentisAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Studenti>> GetStudenti(int id)
        {
            var studenti = await _context.Students.FindAsync(id);

            if (studenti == null)
            {
                return NotFound();
            }

            return studenti;
        }

        // PUT: api/StudentisAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}"), Authorize(Roles = "Admin") ]
        public async Task<IActionResult> PutStudenti(int id, Studenti studenti)
        {
            if (id != studenti.Id)
            {
                return BadRequest();
            }

            _context.Entry(studenti).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentiExists(id))
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

        // POST: api/StudentisAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost ,Authorize(Roles = "Admin")]
        public async Task<ActionResult<Studenti>> PostStudenti(Studenti studenti)
        {
            _context.Students.Add(studenti);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudenti", new { id = studenti.Id }, studenti);
        }

        // DELETE: api/StudentisAPI/5
        [HttpDelete("{id}"),Authorize (Roles = "Admin")]
        public async Task<IActionResult> DeleteStudenti(int id)
        {
            var studenti = await _context.Students.FindAsync(id);
            if (studenti == null)
            {
                return NotFound();
            }

            _context.Students.Remove(studenti);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentiExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
