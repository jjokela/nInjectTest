using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nInjectTest.Models
{
    public class DbLogger : ILogger
    {
        public string GetLoggerType()
        {
            return "DbLogger";
        }

        public void Log(string message, DateTime created)
        {
            throw new NotImplementedException();
        }
    }
}