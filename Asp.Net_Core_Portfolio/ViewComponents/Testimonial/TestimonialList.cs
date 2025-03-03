using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Portfolio.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
    }
}
