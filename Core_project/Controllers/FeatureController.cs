using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Öne çıkanlar";
            ViewBag.v3 = "Index";

            var values = featuremanager.TGetByID(1);
            return View(values);
        }
    
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            featuremanager.TUpdate(p);
            return RedirectToAction("Index","Default");
        }

    }
}
