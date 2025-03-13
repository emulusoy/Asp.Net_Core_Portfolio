using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.Controllers
{
    [Authorize]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {

            var values = experienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {

            var values = experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
