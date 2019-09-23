using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation.Interfaces
{
    interface ICheckIn
    {
        string Quarter { get; set; }
        string ProjectUpdate { get; set; }
        string GoalsUpdate { get; set; }
        string SoftwareCertificateUpdate { get; set; }
        string SoftwareTrainingNeeded { get; set; }
        string TestingFrameworksUsed { get; set; }
        string UpcomingJunior { get; set; }
        string SeniorRoleModel { get; set; }
    }
}
