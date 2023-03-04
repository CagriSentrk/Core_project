using Core_project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }


    }
}
