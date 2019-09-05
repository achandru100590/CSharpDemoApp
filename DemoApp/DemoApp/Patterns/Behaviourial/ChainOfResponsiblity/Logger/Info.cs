using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Logger
{
    public class Info : LoggerHandler
    {
        public override void Log(string logType)
        {
            if (logType == "info")
            {
                Console.WriteLine("This is info log");
            }
            else
            {
                loggerHandler.Log(logType);
            }
        }
    }
}
