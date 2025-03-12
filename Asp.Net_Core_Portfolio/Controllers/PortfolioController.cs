using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager=new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {

            var values=portfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProject()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator(); 
            ValidationResult result = validations.Validate(p);
            if (result.IsValid) {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }
        public IActionResult DeleteProject(int id)
        {
            var values = portfolioManager.TGetById(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditProject(int id)
        {

            var values = portfolioManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditProject(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                portfolioManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }

    }
}
