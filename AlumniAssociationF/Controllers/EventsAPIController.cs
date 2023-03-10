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
    public class EventsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EventsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eventet>>> GetEventet()
        {
            return await _context.Eventet.ToListAsync();
        }

        // GET: api/EventsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eventet>> GetEventet(int id)
        {
            var eventet = await _context.Eventet.FindAsync(id);

            if (eventet == null)
            {
                return NotFound();
            }

            return eventet;
        }

        // PUT: api/EventsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventet(int id, Eventet eventet)
        {
            if (id != eventet.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventetExists(id))
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

        // POST: api/EventsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Eventet>> PostEventet(Eventet eventet)
        {
            _context.Eventet.Add(eventet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventet", new { id = eventet.Id }, eventet);
        }

        // DELETE: api/EventsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventet(int id)
        {
            var eventet = await _context.Eventet.FindAsync(id);
            if (eventet == null)
            {
                return NotFound();
            }

            _context.Eventet.Remove(eventet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventetExists(int id)
        {
            return _context.Eventet.Any(e => e.Id == id);
        }
    }
}
