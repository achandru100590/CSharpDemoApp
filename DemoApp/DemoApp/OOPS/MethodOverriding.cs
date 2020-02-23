using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am from base classe");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am from derived classe");
        }

    }
}
