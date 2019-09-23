using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.LiskovSubstitution.Models;

namespace Solid.LiskovSubstitution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Feedback()
        {
            //simulation feedback input
            var feedback = new Feedback()
            {
                FeedbackText = "Amazing consultant, knew everything about Single Responsibility & Open/Closed Principles",
                PreviewText = "In the next quarter the consultant will play with the other 3 SOLID pilars",
                ScoreCommunication = 9,
                ScoreInitiativeApproach = 8,                
                ScoreTechnicalSkills = 0
            };

            //submit input
            //... submitting ....

            //submit was success
            return View("Success", feedback);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
