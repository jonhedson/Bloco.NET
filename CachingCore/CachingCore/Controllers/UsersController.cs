using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CachingCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CachingCore.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(Drink d)
        //{
        //    ViewBag.Coffee = d.Coffee;
        //    ViewBag.Tea = d.Tea;
        //    ViewBag.Milk = d.Milk;
        //    return View("Results");
        //}

        [HttpPost]
        public IActionResult Index(Hotel h)
        {
            ViewBag.TeaType = h.TeaType.ToString();
            ViewBag.HotelType = h.HotelType.ToString();
            return View("Results");
        }
    }
}
