using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
