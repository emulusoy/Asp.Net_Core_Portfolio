﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TodoList
    {
        [Key]
        public int TodoId { get; set; }
        public string ToDoContent { get; set; }
        public bool ToDoStatus { get; set; }
    }
}
