using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab1_1.Models;
using System.IO;

namespace lab1_1.Controllers
{
    public class DateController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            string path = @"event.txt";
            List<string> list = new List<string>();
             using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            TimeSpan difference = Convert.ToDateTime(list[0]) - DateTime.Now;
            double dayCount = 365.0;
            double year = difference.Days / dayCount;
            string result = $"Event name: {list[1]} \nyears: {year} \ndays: {difference.Days} \nhours: {difference.Hours} \nmin: {difference.Minutes} \nsec: {difference.Seconds} \nDateNow: {DateTime.Now} \nEvent Date: {Convert.ToDateTime(list[0])}";
            return Content(result);
        }

    }
}
