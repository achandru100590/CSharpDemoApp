using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public abstract class BankBase
    {
        public virtual double Interest()
        {
            return 11.5;
        }

    }
    public class HDFC : BankBase
    {
        public override double Interest()
        {
            return 9.5;
        }
    }
    public class IOB : BankBase
    {
        public override double Interest()
        {
            return base.Interest();
        }
    }
    public class SBI : BankBase
    {
        public override double Interest()
        {
            return base.Interest();
        }
    }
}
