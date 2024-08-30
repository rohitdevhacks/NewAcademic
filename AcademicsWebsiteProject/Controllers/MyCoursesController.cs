using Microsoft.AspNetCore.Mvc;

namespace AcademicsWebsiteProject.Controllers
{
    public class MyCoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
