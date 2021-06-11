using System;

namespace DemoApp.Patterns.Behaviourial.Strategy
{
    public interface IAuthenticationStatergy
    {
        void Authentiate();
    }

    public class SingleFactorAuthentication : IAuthenticationStatergy
    {
        public void Authentiate()
        {
            Console.WriteLine("SFA is done by UserName and Password");
        }
    }

    public class TwoFactorAuthentication : IAuthenticationStatergy
    {
        public void Authentiate()
        {
            Console.WriteLine("2FA is done by UserName,Password and Otp");
        }
    }

    public class MultiFactorAuthentication : IAuthenticationStatergy
    {
        public void Authentiate()
        {
            Console.WriteLine("MFA is done by UserName,Password, OTP and Questions");
        }
    }

    public enum AuthenticationType
    {
        UserNameAndPassword = 1,
        OTP,
        QustionAndOTP
    }
}