using System;
using System.Collections.Generic;

namespace DemoApp.Patterns.Behaviourial.Mediaor
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, FaceBookUser user);

        void RegisterUser(FaceBookUser user);
    }

    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<FaceBookUser> usersList = new List<FaceBookUser>();

        public void RegisterUser(FaceBookUser user)
        {
            usersList.Add(user);
        }

        public void SendMessage(string message, FaceBookUser user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }

    public abstract class FaceBookUser
    {
        protected FacebookGroupMediator mediator;
        protected string name;

        public FaceBookUser(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }

    public class ConcreteUser : FaceBookUser
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}