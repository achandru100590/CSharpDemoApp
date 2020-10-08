namespace DemoApp.OOPS
{
    public class BankBase
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

    }
    public class SBI : BankBase
    {

    }
}
