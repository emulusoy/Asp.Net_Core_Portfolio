
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Asp.Net_Core_Portfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly Microsoft.AspNetCore.Identity.UserManager<WriterUser> _userManager;

        public MessageController(Microsoft.AspNetCore.Identity.UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async  Task<IActionResult> ReceiverMessage(string p)
        {          
            var values=await _userManager.FindByNameAsync(User.Identity.Name);

            p = values.Email;
            var messageList=writerMessageManager.GetListReceiverMessage(p);
            
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            p = values.Email;
            var messageList = writerMessageManager.GetListSendMessage(p);

            return View(messageList);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage message = writerMessageManager.TGetById(id);
            return View(message);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage message = writerMessageManager.TGetById(id);
            return View(message);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c=new Context();
            var userNameSurname=c.Users.Where(x => x.Email == mail).Select(x => x.Name+" "+x.UserName).FirstOrDefault();
            p.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
