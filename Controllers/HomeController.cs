﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Todo.Models;

namespace Todo.Controllers
{
    public sealed class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}