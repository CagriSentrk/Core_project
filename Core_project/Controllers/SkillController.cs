using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
