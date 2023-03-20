using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Core_project.Areas.Writer.Controllers

{
    [Area("Writer")]
    public class DashboardController : Controller

    {
        private readonly UserManager<WriterUser> _usermanager;

        public DashboardController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task <IActionResult> Index()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name + " " + values.Surname;
            //weather Api

            string api = "90e8c977632b3de426b3d61c7b5bddea";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document=XDocument.Load(connection);
            ViewBag.v6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;



            //Statistics
            Context c = new Context();
            ViewBag.v2 = 0;
            ViewBag.v3 = c.Announcements.Count();
            ViewBag.v4 = 0;
            ViewBag.v5 = c.Skills.Count();

            return View();
        }
    }
}
//https://api.openweathermap.org/data/2.5/weather?q=Ankara&mode=xml&lang=tr&units=metric&appid=90e8c977632b3de426b3d61c7b5bddea