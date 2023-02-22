using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
