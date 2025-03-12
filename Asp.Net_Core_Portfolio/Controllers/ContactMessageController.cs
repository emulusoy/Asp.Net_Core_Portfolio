using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class ContactMessageController : Controller
    {

        SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = sendMessageManager.GetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = sendMessageManager.TGetById(id);
            sendMessageManager.TDelete(values);
            return RedirectToAction("Index");  
        }
        public IActionResult ContactDetails(int id)
        {
            var values = sendMessageManager.TGetById(id);
            
            return View(values);
        }
    }
}
