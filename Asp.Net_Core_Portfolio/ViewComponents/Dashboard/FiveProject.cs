using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Dashboard
{
    public class FiveProject : ViewComponent
    {
  
        public IViewComponentResult Invoke()
        {
    
            return View();
        }
    }
}
