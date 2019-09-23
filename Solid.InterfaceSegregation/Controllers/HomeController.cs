using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.InterfaceSegregation.Models;

namespace Solid.InterfaceSegregation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var checkIn = new JuniorDotNetCheckIn
            {
                Quarter = "Q3",
                ProjectUpdate = "I've been a good boi.",
                GoalsUpdate = "I already learned the single responsibility, open/closed & liskov substitution principle.",
                SoftwareCertificateUpdate = "Exam 70-483: Programming in C#",
                SoftwareTrainingNeeded = "I wish I had a Blazor training this afternoon.",
                SeniorRoleModel = "/, I don't know anyone"
            };

            return View(checkIn);
        }

        [HttpPost]
        public IActionResult SubmitCheckIn(JuniorDotNetCheckIn checkIn)
        {
            //Submit checkin
            //...

            var success = true;

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
