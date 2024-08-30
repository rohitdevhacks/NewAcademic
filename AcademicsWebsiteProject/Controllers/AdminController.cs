using AcademicsWebsiteProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicsWebsiteProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext db;
        private IWebHostEnvironment env;

        public AdminController(ApplicationDbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
