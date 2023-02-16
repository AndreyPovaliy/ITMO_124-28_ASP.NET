using Final_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_task.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ViewResult Index() 
        {
            int hour = DateTime.Now.Hour; ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
            return View();
        }
        
        [HttpGet]
        public ViewResult InputData() 
        { 
            return View(); 
        }

        [HttpPost]
        public ViewResult InputData(Students p)
        {
            return View("After_adding", p);
        }
    }
}