using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
