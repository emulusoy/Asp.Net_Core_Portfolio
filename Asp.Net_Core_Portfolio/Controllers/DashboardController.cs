using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Add Dashboard Page";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Add Dashboard";
            return View();
        }
    }
}
