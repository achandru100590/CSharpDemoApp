using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Logger
{
    public abstract class LoggerHandler
    {
        public LoggerHandler loggerHandler;
       
        public void SetNextLoggerHandler(LoggerHandler loggerHandler)
        {
            this.loggerHandler = loggerHandler;
        }

        public abstract void Log(string logType);
    }
}
