using AlumniAssociationF.Data;
using AlumniAssociationF.Models;
using AlumniAssociationF.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using System.Data;
using static NuGet.Packaging.PackagingConstants;

namespace AlumniAssociationF.Areas.Admin.Controllers
{
    [Area("Admin")]

    
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        public static User user = new User();
        private readonly ApplicationDbContext _context;


        public UserController( UserManager<IdentityUser> _userManager,  ApplicationDbContext context)
        {         
            userManager = _userManager;
            _context = context;
        }


        // GET: UserController

        [HttpGet]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
          

            return View(await _context.Users.ToListAsync());

        }

        // GET: UserController/Details/5
        [HttpGet]
       [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var studenti = await _context.Users.FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (studenti == null)
            {
                return NotFound();
            }

            return View(studenti);
        }

        // GET: UserController/Create


        // GET: UserController/Edit/5
        [HttpGet]
      [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }
            
            var studenti =  await _context.Users.FirstOrDefaultAsync(u => u.Id ==id.ToString());
            if (studenti == null)
            {
                return NotFound();
            }
            return View(studenti);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(User u)
        {
            var user = await _context.Users.FindAsync(u.Id);

            if (user == null)
            {
                ViewBag.ErroreMessage = $"User with ID = {u.Id} cannot be found";
                return View("NotFound");
            }


            if (user == null)
            {
                ViewBag.ErroreMessage = $"User with ID = {u.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user = u;

                
                
                _context.Update(user);
               var result=  await _context.SaveChangesAsync();
               
                return View(u);
            }
        }
    }
}
