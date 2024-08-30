using Microsoft.AspNetCore.Mvc;

namespace AcademicsWebsiteProject.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleCourse()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
