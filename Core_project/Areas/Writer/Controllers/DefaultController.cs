using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {

        AnnouncementManager Announcementmanager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {

            var values=Announcementmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = Announcementmanager.TGetByID(id);
            return View(announcement);
        }

    }
}
