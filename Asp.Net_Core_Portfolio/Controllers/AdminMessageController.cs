using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = messageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = messageManager.GetListSendMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            
            var values = messageManager.TGetById(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = messageManager.TGetById(id);

            if (values != null)
            {
                messageManager.TDelete(values);
                if (values.Receiver == "admin@gmail.com")
                {
                    return RedirectToAction(nameof(ReceiverMessageList));
                }
                else if (values.Sender == "admin@gmail.com")
                {
                    return RedirectToAction(nameof(SenderMessageList));
                }
            }
            return RedirectToAction(nameof(SenderMessageList));
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToLongDateString());
            Context c = new Context();
            var userNameSurname = c.Users.Where(x => x.Email.Equals(p.Receiver)).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = userNameSurname;
            messageManager.TAdd(p);
            return RedirectToAction(nameof(SenderMessageList));
        }


    }
}
