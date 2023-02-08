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
    public class StudentisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Studentis
        public async Task<IActionResult> Index()
        {
              return View(await _context.Students.ToListAsync());
        }

        // GET: Admin/Studentis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studenti = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studenti == null)
            {
                return NotFound();
            }

            return View(studenti);
        }

        // GET: Admin/Studentis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Studentis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Birthday,Email,Contact,City,State,University,AvGrade,Gender,JobStatus")] Studenti studenti)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studenti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studenti);
        }

        // GET: Admin/Studentis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studenti = await _context.Students.FindAsync(id);
            if (studenti == null)
            {
                return NotFound();
            }
            return View(studenti);
        }

        // POST: Admin/Studentis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Birthday,Email,Contact,City,State,University,AvGrade,Gender,JobStatus")] Studenti studenti)
        {
            if (id != studenti.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studenti);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentiExists(studenti.Id))
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
            return View(studenti);
        }

        // GET: Admin/Studentis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studenti = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studenti == null)
            {
                return NotFound();
            }

            return View(studenti);
        }

        // POST: Admin/Studentis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Students'  is null.");
            }
            var studenti = await _context.Students.FindAsync(id);
            if (studenti != null)
            {
                _context.Students.Remove(studenti);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentiExists(int id)
        {
          return _context.Students.Any(e => e.Id == id);
        }
    }
}
