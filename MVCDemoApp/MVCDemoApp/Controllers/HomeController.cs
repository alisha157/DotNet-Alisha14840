using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/Greet/{name}")]
        public IActionResult Greet(string name)
        {
            //return Content("Welcome to MVC");
            //return View("Greet1");
            ViewBag.wish = "Hello " + name;
            return View();
        }

        //Create an action - AddNumbers
        //which takes two integer parameters
        //display addition of numbers in browser

        [Route("Home/AddNumbers/{n1?}/{n2?}")]
        public IActionResult AddNumbers(int n1, int n2)
        {
            int result = n1 + n2;
            ViewBag.result = $" {n1} + {n2} = {result}";
            //ViewBag.result = n1 + n2;
            return View();
        }

        [HttpPost("home/sum/{num1:int}/{num2:int:range(1,10)}")]
        public IActionResult AddNum(int num1=0, int num2=0)
        {
            int result = num1 + num2;
            ViewBag.result = result;
            return View();
        }

        public IActionResult GetData(int id)
        {
            ViewBag.message = "Id = " + id;
            return View();
        }

        public IActionResult ModelDemo()
        {
            Employee employee = new Employee { EmpId = 1, EmpName = "alisha", Salary = 10000 };
            //ViewBag.emp = employee;
            ViewData["emp"] = employee;
            return View();
        }

        public IActionResult EmployeeForm()
        { 
            return View(new Employee());
        }

        public IActionResult DisplayEmployeeData(Employee employee)
        { 
            if(ModelState.IsValid)
            {
                return View(employee);
            }
            return View("EmployeeForm", employee);
            
        }

        


    }
}
