using Microsoft.AspNetCore.Mvc;

namespace AcademicsWebsiteProject.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
