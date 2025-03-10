
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Areas.Writer.ViewComponents
{
    public class NavbarPhoto:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavbarPhoto(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.ImageV = values.ImageUrl;
            return View();
        }
    }
}
