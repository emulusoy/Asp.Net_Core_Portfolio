using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()

        {

            var values=skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {

        return View();  
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skillManager.TAdd(p);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values=skillManager.TGetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {

            var values = skillManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            skillManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
