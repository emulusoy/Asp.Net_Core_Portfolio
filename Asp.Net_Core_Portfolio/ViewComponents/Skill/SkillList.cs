using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetList();
            return View(values);
        }
    }
}
