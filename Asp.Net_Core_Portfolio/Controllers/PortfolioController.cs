using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager=new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Projects Page";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Projects List";
            var values=portfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            ViewBag.v1 = "Add Project Page";
            ViewBag.v2 = "Project";
            ViewBag.v3 = "Add Project";
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Portfolio p)
        {
            portfolioManager.TAdd(p);

            return RedirectToAction("Index");
        }

    }
}
