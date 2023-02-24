using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
           

            return View();
        }
    }
}
