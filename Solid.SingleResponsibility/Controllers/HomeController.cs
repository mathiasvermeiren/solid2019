using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.SingleResponsibility.Models;

namespace Solid.SingleResponsibility.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var checkIn = new CheckIn
            {
                Quarter = "Q3",
                ProjectUpdate = "I've been a good boi.",
                GoalsUpdate = "Worked on my certifications, did a boatload."
            };

            return View(checkIn);
        }

        [HttpPost]
        public IActionResult SubmitCheckIn(CheckIn checkIn)
        {
            checkIn.Log();
            var success = checkIn.NotifyCoach();
            if (success)
            {
                return View("Success", checkIn);
            }

            return View("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
