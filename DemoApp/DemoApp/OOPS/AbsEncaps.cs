using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public interface IBeverage
    {
        void AddSugar();
        void AddWatter();
        void AddMilk();
        void AddPowder();
    }
    public abstract class Beverage
    {
        public void AddMilk()
        {
            Console.WriteLine("Milk is added.");
        }

        public void AddSugar()
        {
            Console.WriteLine("Sugar is added.");
        }

        public void AddWatter()
        {
            Console.WriteLine("Watter is added.");
        }
        public abstract void AddPowder();
    }
    public class Tea : Beverage
    {
        public override void AddPowder()
        {
            Console.WriteLine("Tea powder is added.");
        }
    }
    public class Coffee : Beverage
    {
        public override void AddPowder()
        {
            Console.WriteLine("Coffee powder is added.");
        }
    }
    public class BeverageMaker
    {
        public void Make(Beverage beverage)
        {
            beverage.AddSugar();
            beverage.AddWatter();
            beverage.AddMilk();
            beverage.AddPowder();
        }
    }
}
