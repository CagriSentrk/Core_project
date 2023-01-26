using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Contact
{
    public class ContactDetails: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
