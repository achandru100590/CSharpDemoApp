using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public class BaseClass2
    {
        public void Print()
        {
            Console.WriteLine("I am from base classe");
        }
    }
    public class DerivedClass2 : BaseClass2
    {
        public new void Print()
        {
            Console.WriteLine("I am from derived classe");
        }

    }
}
