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
    public class OurProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OurProgramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/OurPrograms
        public async Task<IActionResult> Index()
        {
              return View(await _context.OurProgram.ToListAsync());
        }

        // GET: Admin/OurPrograms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OurProgram == null)
            {
                return NotFound();
            }

            var ourProgram = await _context.OurProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourProgram == null)
            {
                return NotFound();
            }

            return View(ourProgram);
        }

        // GET: Admin/OurPrograms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/OurPrograms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      //  [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Title,Description")] OurProgram ourProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourProgram);
        }

        // GET: Admin/OurPrograms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OurProgram == null)
            {
                return NotFound();
            }

            var ourProgram = await _context.OurProgram.FindAsync(id);
            if (ourProgram == null)
            {
                return NotFound();
            }
            return View(ourProgram);
        }

        // POST: Admin/OurPrograms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Title,Description")] OurProgram ourProgram)
        {
            if (id != ourProgram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurProgramExists(ourProgram.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ourProgram);
        }

        // GET: Admin/OurPrograms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OurProgram == null)
            {
                return NotFound();
            }

            var ourProgram = await _context.OurProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourProgram == null)
            {
                return NotFound();
            }

            return View(ourProgram);
        }

        // POST: Admin/OurPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OurProgram == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OurProgram'  is null.");
            }
            var ourProgram = await _context.OurProgram.FindAsync(id);
            if (ourProgram != null)
            {
                _context.OurProgram.Remove(ourProgram);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurProgramExists(int id)
        {
          return _context.OurProgram.Any(e => e.Id == id);
        }
    }
}
