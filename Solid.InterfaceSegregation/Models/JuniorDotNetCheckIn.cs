using Solid.InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation.Models
{
    public class JuniorDotNetCheckIn : ICheckIn
    {
        public string Quarter { get; set; }
        public string ProjectUpdate { get; set; }
        public string GoalsUpdate { get; set; }
        public string SoftwareCertificateUpdate { get; set; }
        public string SoftwareTrainingNeeded { get; set; }
        public string TestingFrameworksUsed { get; set; }
        public string UpcomingJunior { get; set; }
        public string SeniorRoleModel { get; set; }
    }
}
