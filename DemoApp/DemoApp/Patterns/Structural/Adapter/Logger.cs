using System;

namespace DemoApp.Patterns.Structural.Adapter
{
    //https://levelup.gitconnected.com/the-simplest-explanation-of-adapter-design-pattern-cd37f02bfecd
    public interface ILogger
    {
        void Log(LogEntry entry);
    }

    public class LogEntry
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }

    public class FileLogger : ILogger
    {
        public void Log(LogEntry entry)
        {
            //log {entry.Text} and {entry.Time} to file
        }
    }

    /// <summary>
    ///  Legacy Service having db logger.
    /// </summary>
    public class DatabaseLogger
    {
        public void Log(string entry)
        {
        }
    }

    public class DatabaseLoggerAdapter : ILogger
    {
        private DatabaseLogger _databaseLogger = new DatabaseLogger();

        public void Log(LogEntry entry)
        {
            string text = $"{entry.Text} logged at {entry.Time}.";
            _databaseLogger.Log(text);
        }
    }
}