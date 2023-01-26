using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager serviceManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {

           var values= serviceManager.TGetList();
            return View(values);
        }
    }
}
