using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_project.ViewComponents.Dashboard
{
    public class Last5Project:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
    
        public IViewComponentResult Invoke()
        {

            //Burada, OrderByDescending metodu ile kayıtları Id'ye göre azalan sıraya göre sıralıyoruz. Take metodu ile de ilk 5 kaydı alıyoruz.
            var values = portfolioManager.TGetList().OrderByDescending(x=>x.PortfolioID).Take(5).ToList(); //son 5 projeyi aldı.

            return View(values);
        }
    }
}
