using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.OpenClosed.Models;
using Solid.OpenClosed.Services;

namespace Solid.OpenClosed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var checkIn = new CheckIn
            {
                Quarter = "Q4",
                ProjectUpdate = "I've been a good boi.",
                GoalsUpdate = "I already learned the single responsibility principle."
            };

            return View(checkIn);
        }

        [HttpPost]
        public IActionResult SubmitCheckIn(CheckIn checkIn)
        {
            NotificationService notificationService = new NotificationService();
            var success = notificationService.SendBySms("1", "T1");

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
