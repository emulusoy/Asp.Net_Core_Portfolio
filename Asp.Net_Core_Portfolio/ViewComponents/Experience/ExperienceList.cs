using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experienceManager=new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceManager.GetList();
            return View(values);
        }
    }
}
