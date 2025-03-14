using Core_Api.DAL.ApiContext;
using Core_Api.DAL.ApiEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
         public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());//2000 kodlu api calisiyorumu
        }
        [HttpGet]
        public IActionResult CategoryGet(int id)
        {
            using var c = new Context();
           var value=c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);   
            }

        }
        [HttpPost]
        public IActionResult CategoryPost(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("",p);

        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }

        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName=p.CategoryName;
                c.Add(value);
                c.SaveChanges();
                return NoContent();
            }
            
                
       }


    }
}
