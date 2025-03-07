using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit About Page";
            ViewBag.v2 = "About";
            ViewBag.v3 = "Edit About";
            var values = aboutManager.TGetById(3);
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(About p)
        {
            aboutManager.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
