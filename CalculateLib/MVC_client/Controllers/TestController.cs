using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculateLib;

namespace MVC_client.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Calculate obj = new Calculate();
            int result = obj.Add(12, 19);
            ViewData["res"] = result;
            return View();
        }
        public IActionResult Greets( string names)
        {
            Calculate obj = new Calculate();
            //string name = obj.Greet("Anjani");
            string name = obj.Greet(names);
            ViewData["name"] = name;
            return View();
        }
        public IActionResult Listname()
        {
            Calculate obj = new Calculate();
            //string name = obj.Greet("Anjani");
            List<string> Lname = obj.getNames();
            ViewData["Lname"] = Lname;
            return View();
        }
    }
}