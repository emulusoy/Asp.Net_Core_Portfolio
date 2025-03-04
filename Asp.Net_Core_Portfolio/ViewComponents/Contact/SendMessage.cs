using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        SendMessageManager messageManager = new SendMessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.MessageStatus = true; 
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
