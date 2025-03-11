using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
