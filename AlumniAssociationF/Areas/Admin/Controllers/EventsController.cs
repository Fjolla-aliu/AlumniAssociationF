using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlumniAssociationF.Data;
using AlumniAssociationF.Models;

namespace AlumniAssociationF.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Events
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eventet.Include(e => e.Program);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Eventet == null)
            {
                return NotFound();
            }

            var eventet = await _context.Eventet
                .Include(e => e.Program)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventet == null)
            {
                return NotFound();
            }

            return View(eventet);
        }

        // GET: Admin/Events/Create
        public IActionResult Create()
        {
            ViewData["ProgramId"] = new SelectList(_context.Programs, "Id", "Description");
            return View();
        }

        // POST: Admin/Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Author,Image,Title,Date,Description,Location,Deadline,ProgramId")] Eventet eventet)
        {
         
                _context.Add(eventet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            ViewData["ProgramId"] = new SelectList(_context.Programs, "Id", "Description", eventet.ProgramId);
            return View(eventet);
        }

        // GET: Admin/Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Eventet == null)
            {
                return NotFound();
            }

            var eventet = await _context.Eventet.FindAsync(id);
            if (eventet == null)
            {
                return NotFound();
            }
            ViewData["ProgramId"] = new SelectList(_context.Programs, "Id", "Description", eventet.ProgramId);
            return View(eventet);
        }

        // POST: Admin/Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,Image,Title,Date,Description,Location,Deadline,ProgramId")] Eventet eventet)
        {
            if (id != eventet.Id)
            {
                return NotFound();
            }

                try
                {
                    _context.Update(eventet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventetExists(eventet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramId"] = new SelectList(_context.Programs, "Id", "Description", eventet.ProgramId);
            return View(eventet);
        }

        // GET: Admin/Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Eventet == null)
            {
                return NotFound();
            }

            var eventet = await _context.Eventet
                .Include(e => e.Program)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventet == null)
            {
                return NotFound();
            }

            return View(eventet);
        }

        // POST: Admin/Events/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Eventet == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eventet'  is null.");
            }
            var eventet = await _context.Eventet.FindAsync(id);
            if (eventet != null)
            {
                _context.Eventet.Remove(eventet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventetExists(int id)
        {
          return _context.Eventet.Any(e => e.Id == id);
        }
    }
}
