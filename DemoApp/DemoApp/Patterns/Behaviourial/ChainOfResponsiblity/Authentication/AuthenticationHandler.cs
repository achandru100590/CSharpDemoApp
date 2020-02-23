using DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Aunthentication
{
    public abstract class AuthenticationHandler
    {
        protected AuthenticationHandler Handler;
        public void SetAuthenticationHandler(AuthenticationHandler authenticationHandler)
        {
            Handler = authenticationHandler;
        }
        public abstract void Authendicate(AuthenticationType authenticationType);        
    }
}
