using DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Aunthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Authentication
{
    public class SingleFactorAuthentication : AuthenticationHandler
    {     
        public override void Authendicate(AuthenticationType authenticationType)
        {
            if (authenticationType == AuthenticationType.UserNameAndPassword)
            {
                Console.WriteLine("SingleFactorAuthentication is done");
            }
            else
            {
                Handler.Authendicate(authenticationType);
            }
        }
    }
}
