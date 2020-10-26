using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab1_1.Models;

namespace lab1_1.Controllers
{
    public class DateController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name, DateTime date)
        {
            TimeSpan difference = DateTime.Now - date;
            string result = $"Name: {name}   days: {difference.Days} hours: {difference.Hours} min: {difference.Minutes} sec: {difference.Seconds}";
            return Content(result);
        }

    }
}
