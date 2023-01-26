using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Contact
{
    public class ContactDetails: ViewComponent
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactmanager.TGetList();

            return View(values);
        }
    }
}
