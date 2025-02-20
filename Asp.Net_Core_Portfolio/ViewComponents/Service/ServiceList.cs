using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetList();
            return View(values);
        }
    }
}
