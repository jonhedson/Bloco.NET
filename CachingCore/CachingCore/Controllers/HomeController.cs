using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CachingCore.Models;

namespace CachingCore.Controllers
{
    public class HomeController : Controller
    {
        
        [ResponseCache(Duration = 5)]
        public IActionResult Index()
        {
            return View(DateTime.Now);
        }

        [ResponseCache(Duration = 10, VaryByQueryKeys = new[] { "teste" })]
        public IActionResult Details(int d)
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration = 2)]
        public IActionResult Privacy()
        {
            return View(DateTime.Now);
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
