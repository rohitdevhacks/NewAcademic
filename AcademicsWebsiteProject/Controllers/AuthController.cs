using AcademicsWebsiteProject.Data;
using AcademicsWebsiteProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademicsWebsiteProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext db;
        public AuthController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User u) 
        {
            u.Role = "User";
            db.UserInfo.Add(u);
            db.SaveChanges();
            return RedirectToAction("SignIn");
        }

        public IActionResult SignIn() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(SignIn log)
        {
            var data = db.UserInfo.Where(x => x.Username.Equals(log.Username)).SingleOrDefault();
            if (data != null)
            {
                bool us = data.Username.Equals(log.Username) && data.Password.Equals(log.Password);
                if (us)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["IncorrectEmail"] = "IncorrectEmail";
                }
            }
            else
            {
                TempData["IncorrectPassword"] = "Incorrect Password";
            }
            return View();
        }
    }
}
