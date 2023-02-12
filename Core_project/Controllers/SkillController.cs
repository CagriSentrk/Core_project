using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skillmanager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillmanager.TGetByID(id);
            skillmanager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            skillmanager.TUpdate(p);
            return RedirectToAction("Index");
        }



    }
}
