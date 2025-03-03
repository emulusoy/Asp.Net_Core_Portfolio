using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialCompany { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageUrl { get; set; }
        public string TestimonialStatus { get; set; }
    }
}
