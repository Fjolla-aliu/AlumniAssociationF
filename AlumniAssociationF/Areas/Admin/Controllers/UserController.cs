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

    //[Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        public static User user = new User();


        public UserController( UserManager<IdentityUser> _userManager)
        {         
            userManager = _userManager;

        }


        // GET: UserController

        [HttpGet]
        public async Task<IActionResult> Index()
        {
           // return View(await userManager.Users.ToListAsync());

            var filters = userManager.Users.ToList();

            var filter = new List<User>();
            foreach (var f in filters)
            {
              
                
                    filter.Add((User)f);
                
            }

            
            return View(filter);
        }

        // GET: UserController/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            var studenti = await userManager.Users.FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (studenti == null)
            {
                return NotFound();
            }

            return View(studenti);
        }

        // GET: UserController/Create


        // GET: UserController/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }
            
            var studenti =  await userManager.Users.FirstOrDefaultAsync(u => u.Id ==id.ToString());
            if (studenti == null)
            {
                return NotFound();
            }
            return View(studenti);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(User u)
        {
            var user = await userManager.FindByIdAsync(u.Id);

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

                
                
                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("/");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(u);
            }
        }
    }
}
