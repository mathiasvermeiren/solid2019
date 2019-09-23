using Solid.DependencyInversion.Models.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.DependencyInversion.Models
{
    public class Processor
    {
        public void RunProcessAndLogInDataBase()
        {
            DbLogger dbLogger = new DbLogger();

            try
            {
                //Run process
            }
            catch (Exception ex)
            {
                dbLogger.LogMessage(ex.Message);
            }
        }

        public void RunProcessAndLogToTextFile()
        {
            TextFileLogger textFileLogger = new TextFileLogger();

            try
            {
                //Run process
            }
            catch (Exception ex)
            {
                textFileLogger.LogMessage(ex.Message);
            }
        }

        public void RunProcessAndSendLogToAdmin()
        {
            EmailLogger emailLogger = new EmailLogger();

            try
            {
                //Run process
            }
            catch (Exception ex)
            {
                emailLogger.LogMessage(ex.Message);
            }
        }
    }
}
