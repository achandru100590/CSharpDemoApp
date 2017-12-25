using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Creational.Singleton
{
    static class ST
    {
        private static int _counter = 0;

        static ST()
        {
            _counter++;
            Console.WriteLine("Counter is : {0}", _counter);
        }
       

        public static void ErrorLog(string message)
        {
            Console.WriteLine("The Error Message : {0}", message);
        }
        public static void DebugLog(string message)
        {
            Console.WriteLine("The Debug Message : {0}", message);
        }
    }
}
