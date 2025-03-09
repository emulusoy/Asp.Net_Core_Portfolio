using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Areas.Writer.Controllers
{
    public class DefaultController : Controller
    {
        [Area("Writer")]//hangi area ile calisacaginiz belirliyoruZ
        public IActionResult Index()
        {
            return View();
        }
    }
}
