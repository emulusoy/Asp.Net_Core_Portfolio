using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Areas.Writer.ViewComponents
{
    public class Notification:ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values=announcementManager.GetList();
            return View(values);
        }
    }
}
