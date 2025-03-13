using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
