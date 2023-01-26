using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager ExperienceManager = new ExperienceManager(new EfExperienceDal());
    public IViewComponentResult Invoke()
        {
            var values = ExperienceManager.TGetList();
            return View(values);
        }
    }
}
