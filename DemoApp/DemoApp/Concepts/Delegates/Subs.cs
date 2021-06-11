using System;

namespace DemoApp.Concepts.Delegates
{
    public class Subs
    {
        public void NotifyMeByEmail(string msg)
        {
            Console.WriteLine("By Email");
        }

        public void NotifyMeByText(string msg)
        {
            Console.WriteLine("By Text");
        }
    }
}