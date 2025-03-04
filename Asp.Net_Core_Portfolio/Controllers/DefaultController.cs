using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return  PartialView();  
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage() 
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            SendMessageManager messageManager = new SendMessageManager(new EfMessageDal());
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.MessageStatus = true;
            messageManager.TAdd(p);
            return PartialView();
        }
    }
}
