using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
