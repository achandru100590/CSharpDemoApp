using System;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity
{
    public abstract class LoggerHandler
    {
        protected LoggerHandler loggerHandler;

        public void SetNextLoggerHandler(LoggerHandler loggerHandler)
        {
            this.loggerHandler = loggerHandler;
        }

        public abstract void Log(string logType);
    }

    public class Warning : LoggerHandler
    {
        public override void Log(string logType)
        {
            if (logType == "Warning")
            {
                Console.WriteLine("This is Warning log");
            }
            else
            {
                loggerHandler.Log(logType);
            }
        }
    }

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