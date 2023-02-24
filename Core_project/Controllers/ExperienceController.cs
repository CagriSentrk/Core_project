using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experiencemanager = new ExperienceManager (new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Tecrübe";
            ViewBag.v3 = "Index";
            var values= experiencemanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Tecrübe";
            ViewBag.v3 = "Add";
            experiencemanager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experiencemanager.TGetByID(id);
            experiencemanager.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Tecrübe";
            ViewBag.v3 = "Update";
            var values=experiencemanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            experiencemanager.TUpdate(p);
                return RedirectToAction("Index");
        }





    }
}
