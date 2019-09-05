using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Logger
{
    public class Error : LoggerHandler
    {
        public override void Log(string logType)
        {
            if (logType == "Error")
            {
                Console.WriteLine("This is Error log");
            }
            else
            {
                loggerHandler.Log(logType);
            }
        }
    }
}
