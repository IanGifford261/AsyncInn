using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Async_Inn.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Async_Inn.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Hotels()
        {
            return RedirectToAction("Hotels", "Index");
        }
    }
}
