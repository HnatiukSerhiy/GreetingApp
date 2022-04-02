using GreetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GreetingApp.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ViewResult Index()
        {
            return View("MyView");
        }
        [HttpPost]
        public ViewResult Greeting(Person person)
        {
            return View("Greeting", person);
        }
    }
}