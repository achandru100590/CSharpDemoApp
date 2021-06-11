using System;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity
{
    public interface IHandler
    {
        void Handle(Requirment requirment);

        void SetNextHandler(IHandler handler);
    }

    public class Architect : IHandler
    {
        private IHandler _handler;

        public void Handle(Requirment requirment)
        {
            if (requirment.IsDesingNeeded)
            {
                requirment.areDBChangesNeeded = true;
                requirment.areAppChangesNeeded = true;

                Console.WriteLine($"{requirment.Name} : Design is done");
            }

            _handler.Handle(requirment);
        }

        public void SetNextHandler(IHandler handler)
        {
            this._handler = handler;
        }
    }

    public class UIDeveloper : IHandler
    {
        private IHandler _handler;

        public void Handle(Requirment requirment)
        {
            if (requirment.areUIChangesNeeded)
            {
                requirment.IsQANeeded = true;
                Console.WriteLine($"{requirment.Name} : UI Changes are done");
            }

            _handler.Handle(requirment);
        }

        public void SetNextHandler(IHandler handler)
        {
            this._handler = handler;
        }
    }

    public class AppDeveloper : IHandler
    {
        private IHandler _handler;

        public void Handle(Requirment requirment)
        {
            if (requirment.areAppChangesNeeded)
            {
                requirment.IsQANeeded = true;
                Console.WriteLine($"{requirment.Name} : App Changes are done");
            }

            _handler.Handle(requirment);
        }

        public void SetNextHandler(IHandler handler)
        {
            this._handler = handler;
        }
    }

    public class DBA : IHandler
    {
        private IHandler _handler;

        public void Handle(Requirment requirment)
        {
            if (requirment.areDBChangesNeeded)
            {
                requirment.IsQANeeded = true;
                Console.WriteLine($"{requirment.Name} : DB Changes are done");
            }

            _handler.Handle(requirment);
        }

        public void SetNextHandler(IHandler handler)
        {
            this._handler = handler;
        }
    }

    public class QA : IHandler
    {
        private IHandler _handler;

        public void Handle(Requirment requirment)
        {
            if (requirment.IsQANeeded)
            {
                Console.WriteLine($"{requirment.Name} : QA is done for this project.. Ready for Delivery!!!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Could not handle the request...");
                Console.WriteLine("");
            }
        }

        public void SetNextHandler(IHandler handler)
        {
            this._handler = handler;
        }
    }

    public class Requirment
    {
        public string Name { get; set; }
        public bool IsDesingNeeded { get; set; }
        public bool areUIChangesNeeded { get; set; }
        public bool areAppChangesNeeded { get; set; }
        public bool areDBChangesNeeded { get; set; }
        public bool IsQANeeded { get; set; }
    }
}