using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent
    {
        SendMessageManager messageManager = new SendMessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var val = messageManager.GetList();
            return View(val);
        }
    }
}
