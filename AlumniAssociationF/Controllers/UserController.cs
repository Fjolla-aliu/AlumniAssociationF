using AlumniAssociationF.Data;
using AlumniAssociationF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AlumniAssociationF.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext context { get; set; }
        private UserManager<User> _userManager { get; set; }
        private SignInManager<User> _signInManager { get; set; }
        private RoleManager<User> _roleManager { get; set; }

        public UserController(ApplicationDbContext context, SignInManager<User> signInManager, UserManager<User> _userManager, RoleManager<User> roleManager)
        {
            this.context = context;
            _signInManager = signInManager;
            this._userManager = _userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            //List<User> Students = this.context.Users.ToList();
            return View();
            //return View(Students);
        }

        [HttpPost]
        public IActionResult Edit(User personi, int id)
        {
            if (string.IsNullOrEmpty(personi.Emri) && personi.Mbiemri == "")
            {
                //error
            }

            if (ModelState.IsValid)
            {//dotnet way

            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //na vijne users nga db
            List<User> users = new List<User>();

            User u1 = new User();
            u1.Emri = "John";
            //u1.Id = 1;
            User u2 = new User();
            u2.Emri = "Filan";
            //u2.Id = 2;
            User u3 = new User();
            u3.Emri = "Test";
            //u3.Id = 3;
            User u4 = new User();
            u4.Emri = "ubt";
            //u4.Id = 4;

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            //

            var userToShow = users.First();

            return View(userToShow);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User personi)
        {
            //if (string.IsNullOrEmpty(personi.Emri) && personi.Mbiemri == "" ) {
            //    //error
            //}

            //if (ModelState.IsValid) {//dotnet way

            //}

            var user = this.context.Users.Add(personi);
            this.context.SaveChanges();

            var currentUser = this._userManager.FindByIdAsync(user.Entity.Id);

            this._userManager.AddToRoleAsync(currentUser.Result, "Administrator");
            this._userManager.AddClaimsAsync(currentUser.Result, "");
            User.IsInRole("Administrator");
            return RedirectToAction("Index");
        }
        //detyra 2.b
        public IActionResult Details(int id)
        {
            //na vijne users nga db
            List<User> users = new List<User>();

            User u1 = new User();
            u1.Emri = "John";
            //u1.Id = 1;
            User u2 = new User();
            u2.Emri = "Filan";
            //u2.Id = 2;
            User u3 = new User();
            u3.Emri = "Test";
            //u3.Id = 3;
            User u4 = new User();
            u4.Emri = "ubt";
            //u4.Id = 4;

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            //

            //var userToShow = users.Where(u => u.Id == id).First();
            var userToShow = users.First();

            return View(userToShow);

        }

        public IActionResult ShowAllUsers()
        {

            List<User> users = new List<User>();

            User u1 = new User();
            u1.Emri = "John";
            //u1.Id = 1;
            u1.DataLindjes = Convert.ToDateTime("01-01-1990");
            User u2 = new User();
            u2.Emri = "Filan";
            //u2.Id = 2;
            u2.DataLindjes = Convert.ToDateTime("01-01-1999");
            User u3 = new User();
            u3.Emri = "Test";
            //u3.Id = 3;
            u3.DataLindjes = Convert.ToDateTime("01-01-1980");
            User u4 = new User();
            u4.Emri = "ubt";
            //u4.Id = 4;
            u4.DataLindjes = Convert.ToDateTime("01-01-2005");

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            return View(users);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult GetUsers()
        {

            List<User> users = new List<User>();

            User u1 = new User();
            u1.Emri = "John";
            //u1.Id = 1;
            u1.DataLindjes = Convert.ToDateTime("01-01-1990");
            User u2 = new User();
            u2.Emri = "Filan";
            //u2.Id = 2;
            u2.DataLindjes = Convert.ToDateTime("01-01-1999");
            User u3 = new User();
            u3.Emri = "Test";
            //u3.Id = 3;
            u3.DataLindjes = Convert.ToDateTime("01-01-1980");
            User u4 = new User();
            u4.Emri = "ubt";
            //u4.Id = 4;
            u4.DataLindjes = Convert.ToDateTime("01-01-2005");

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            return View(users);
        }

        public IActionResult pri()
        {
            var students = this.context.Users.ToList();
            var universities = this.context.University.ToList();

            RegisterViewModel model = new RegisterViewModel();
            model.Universities = universities;
            //model.User = students;
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string url, UserViewModel user)
        {
            if (user == null)
                return BadRequest();

            var currentUser1 = this.context.Users.Where(e => e.Email == user.Email).FirstOrDefault();

            var currentUser = this._userManager.FindByEmailAsync(user.Email);
            var result = this._signInManager.CheckPasswordSignInAsync(currentUser.Result, user.Password, false);


            if (result.IsCompletedSuccessfully)
            {
                return View(url);
            }

            //this._signInManager.SignInAsync("", "", false, null);
            return View();
        }


    }
    public class RegisterViewModel
    {
        public List<User> User { get; set; }
        public List<University> Universities { get; set; }
    }

    public class UserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
