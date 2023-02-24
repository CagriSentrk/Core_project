using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "DASHBOARD";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "İstatistikler";

            return View();
        }
    }
}
