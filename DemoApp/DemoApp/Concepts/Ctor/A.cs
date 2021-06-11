using System;

namespace DemoApp.Concepts.Ctor
{
    public class A : BaseClass
    {
        public A()
        {
            Console.WriteLine("A");
        }

        public A(int a)
        {
            Console.WriteLine("A()");
        }
    }
}