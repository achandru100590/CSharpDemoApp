using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Logger
{
    public class Debug : LoggerHandler
    {

        public override void Log(string logType)
        {
            if(logType == "Debug")
            {
                Console.WriteLine("This is debug log");
            }
            else
            {
                loggerHandler.Log(logType);
            }
        }
    }
}
