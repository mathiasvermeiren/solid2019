using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility.Models
{
    public class CheckIn
    {

        public string Quarter { get; set; }
        public string ProjectUpdate { get; set; }
        public string GoalsUpdate { get; set; }
        public bool NotifyCoach()
        {
            //Send notification 
            return true;
        }
        public void Log()
        {
            //Log Submit 
        }

    }
}
