using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x => x.MessageStatus == false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.MessageStatus == true).Count();
            ViewBag.v4 = c.Experiences.Count();
            return View();
        }
    }
}
