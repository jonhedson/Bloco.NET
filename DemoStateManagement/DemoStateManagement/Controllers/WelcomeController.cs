using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DemoStateManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoStateManagement.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Jonh");
            HttpContext.Session.SetInt32("Age", 32);
            return View();
        }

        public IActionResult Get()
        {
            User newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
        };

            return View(newUser);
    }
}
}
