using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public class BaseClass1
    {
        public virtual void Print()
        {
            Console.WriteLine("I am from base classe");
        } 
    }
    public class DerivedClass1 : BaseClass1
    {
        public new void  Print()
        {
            Console.WriteLine("I am from derived classe");
        }

    }
}
