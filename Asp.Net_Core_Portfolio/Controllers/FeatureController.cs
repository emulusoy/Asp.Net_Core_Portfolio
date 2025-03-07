using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit Feature Page";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Edit Feature";
            var values = featureManager.TGetById(2);
            return View(values);
        }
       

        [HttpPost]
        public IActionResult Index(Feature p)
        {
            featureManager.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}
