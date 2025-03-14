using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class ExperienceAjaxController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            p.ExperienceImageDescription = "2";
            p.ExperienceImageUrl = "2";
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);

        }
        public IActionResult GetByID(int ExperienceID)
        {
            var values = experienceManager.TGetById(ExperienceID);
            var findValues = JsonConvert.SerializeObject(values);
            return Json(findValues);
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return NoContent();
        }
        [HttpPost]
        public IActionResult UpdateExperince([FromBody] Experience p)
        {
            if (p == null)
            {
                return BadRequest("Empty data was sent.");
            }

            var v = experienceManager.TGetById(p.ExperienceID);
            if (v == null)
            {
                return NotFound($"Experience with ID {p.ExperienceID} not found.");
            }

            v.ExperienceName = p.ExperienceName;
            v.ExperienceDate = p.ExperienceDate;

            experienceManager.TUpdate(v);

            return Json(v);
        }

    }
}
