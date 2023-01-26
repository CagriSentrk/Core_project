using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_project.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());

        //component'in en büyük avantajı,partialda ki gibi direkt erişim yok.Yani /Default/FeatureList yazdığınızda erişilmiyor.
        public IViewComponentResult Invoke()
        {
            
            var values = featuremanager.TGetList();
            return View(values);
        }
    }
}
