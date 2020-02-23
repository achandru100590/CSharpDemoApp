using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Authentication
{
    public enum AuthenticationType
    {
        UserNameAndPassword = 1,
        OTP,
        QustionAndOTP
    }
}
