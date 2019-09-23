using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.DependencyInversion.Models.Loggers
{
    public class DbLogger
    {
        public void LogMessage(string message)
        {
            // Open connection
            // Do write
            // Close connection
        }

    }
}
