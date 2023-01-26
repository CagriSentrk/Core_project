using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using BussinesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

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
