using GreetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace GreetingApp.Controllers
{
    public class HomeControllerSerhiy : Controller
    {
        
        [HttpGet]
        public ViewResult Index()
        {
            return View("MyView");
        }

        [HttpPost]
        public ViewResult Greeting(PersonViewModel person)
        {
            return View("Greeting", person);
        }
    }

    public class RoutePrefix : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            string name = controller.ControllerName.Substring(controller.ControllerName.IndexOf("Controller") + "Controller".Length);
            string controller_suffix = "Controller" + name;

            string controller_name;
            controller_name = controller.ControllerName.Replace(controller_suffix, "");

            char[] array = controller_name.ToCharArray();
            Array.Reverse(array);
            controller_name = String.Concat(array);

            controller_name = controller_name.ToLower();
            controller_name = controller_name.First().ToString().ToUpper() + controller_name.Substring(1);

            controller.ControllerName = controller_name;
        }
    }
}