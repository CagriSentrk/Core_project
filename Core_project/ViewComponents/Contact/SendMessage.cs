using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
