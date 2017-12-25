using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Creational.Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;

        private readonly static Lazy<Singleton> singletone = new Lazy<Singleton>(()=>new Singleton());
        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter is : {0}", _counter);
        }

        public static Singleton GetInstance
        {
            get
            {                
                return singletone.Value;
            }
        }

        public  void ErrorLog(string message)
        {
            Console.WriteLine("The Error Message : {0}", message);
        }
        public  void DebugLog(string message)
        {
            Console.WriteLine("The Debug Message : {0}", message);
        }
    }
}
