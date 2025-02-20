using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Asp.Net_Core_Portfolio.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
    }
}
