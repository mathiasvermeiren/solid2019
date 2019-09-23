using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.DependencyInversion.Models.Loggers
{
    public class EmailLogger
    {
        public void LogMessage(string message)
        {
            //send log to admin by mail
        }

    }
}
