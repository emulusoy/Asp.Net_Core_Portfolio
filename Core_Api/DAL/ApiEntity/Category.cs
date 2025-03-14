﻿using System.ComponentModel.DataAnnotations;

namespace Core_Api.DAL.ApiEntity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
