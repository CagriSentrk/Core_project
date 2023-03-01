using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Dashboard
{
    public class toDoListPanel:ViewComponent
    {

        toDoLİstManager toDoLİstManager = new toDoLİstManager(new EftoDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoLİstManager.TGetList();
            return View(values);

        }
    }
}
