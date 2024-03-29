﻿using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {

        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values=userMessageManager.GetUserMessageWithUserService();

            return View(values);
        }
    }
}
