using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nInjectTest.Models
{
    public class FileLogger : ILogger
    {
        public string GetLoggerType()
        {
            return "FileLogger";
        }

        public void Log(string message, DateTime created)
        {
            throw new NotImplementedException();
        }
    }
}