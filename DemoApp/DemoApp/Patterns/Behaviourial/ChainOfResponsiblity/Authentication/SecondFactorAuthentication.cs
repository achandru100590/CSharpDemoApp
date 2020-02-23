using DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Aunthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Authentication
{
    public class SecondFactorAuthentication : AuthenticationHandler
    {
        public override void Authendicate(AuthenticationType authenticationType)
        {
            if (authenticationType == AuthenticationType.OTP)
            {
                Console.WriteLine("SecondFactorAuthentication is done");
            }
            else
            {
                Handler.Authendicate(authenticationType);
            }
        }
    }
}
