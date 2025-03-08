using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Todo
    {
        [Key]
        public int TodoID { get; set; }
        public string TodoContent { get; set; }
        public bool TodoStatus { get; set; }
    }
}
