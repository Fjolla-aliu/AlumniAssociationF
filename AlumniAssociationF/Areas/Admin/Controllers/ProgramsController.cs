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
    public class ProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Programs
        public async Task<IActionResult> Index()
        {
              return View(await _context.Programs.ToListAsync());
        }

        // GET: Admin/Programs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Programs == null)
            {
                return NotFound();
            }

            var program = await _context.Programs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (program == null)
            {
                return NotFound();
            }

            return View(program);
        }

        // GET: Admin/Programs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Programs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      
        public async Task<IActionResult> Create([Bind("Id,Image,Title,Description")] AlumniAssociationF.Models.Program program)
        {
         
                _context.Add(program);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
            return View(program);
        }

        // GET: Admin/Programs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Programs == null)
            {
                return NotFound();
            }

            var program = await _context.Programs.FindAsync(id);
            if (program == null)
            {
                return NotFound();
            }
            return View(program);
        }

        // POST: Admin/Programs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
     
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Title,Description")] AlumniAssociationF.Models.Program program)
        {
            if (id != program.Id)
            {
                return NotFound();
            }

         
                try
                {
                    _context.Update(program);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramExists(program.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            return View(program);
        }

        // GET: Admin/Programs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Programs == null)
            {
                return NotFound();
            }

            var program = await _context.Programs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (program == null)
            {
                return NotFound();
            }

            return View(program);
        }

        // POST: Admin/Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Programs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Programs'  is null.");
            }
            var program = await _context.Programs.FindAsync(id);
            if (program != null)
            {
                _context.Programs.Remove(program);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramExists(int id)
        {
          return _context.Programs.Any(e => e.Id == id);
        }
    }
}
