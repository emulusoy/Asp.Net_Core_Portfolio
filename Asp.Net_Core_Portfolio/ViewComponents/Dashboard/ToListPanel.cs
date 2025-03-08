using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Dashboard
{
    public class ToListPanel : ViewComponent
    {
        IToManager _oManager=new IToManager(new EfToDal());
        public IViewComponentResult Invoke()
        {
            var values = _oManager.GetList();
            return View(values);
        }
    }
}
