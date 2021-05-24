using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDemoApp.Models;

namespace MVCDemoApp.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AttendeeForm()
        {
            return View(new Attendee());
        }

        public IActionResult DisplayAttendeeData(Attendee attendee)
        {
            ViewBag.DefaultMessage = "Thank You " + attendee.Name;
            if (attendee.WillAttend == "Yes")
            {
                ViewBag.Message = "It's great that you're coming";
            }
            if (attendee.WillAttend == "No")
            {
                ViewBag.Message = "Sorry to hear that you can't make it, but thanks for letting us know";
            }

            return View();

        }
    }
}
