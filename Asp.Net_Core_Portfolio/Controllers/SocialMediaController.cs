using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.SocialMediaStatus = true;
            socialMediaManager.TAdd(p);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetById(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia p)
        {
            socialMediaManager.TUpdate(p);
            return RedirectToAction(nameof(Index));
        }

    }
}
