﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.Net_Core_Portfolio.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p) {

            writerUserManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        
        }

    }
}
