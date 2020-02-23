using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public interface ICar
    {
        double Price();
    }
    interface INewFeatures
    {
        string GPS();

    }
    public class Audi : CarBase, INewFeatures
    {
        public string GPS()
        {
            return "GPS is available";
        }

        public override double Price()
        {
            return 1300000;
        }
    }
    public class BMW : CarBase, INewFeatures
    {
        public string GPS()
        {
            return "GPS is available";
        }

        public override double Price()
        {
            return 1200000;
        }

    }
    public class Honda : CarBase //, ICar
    {
        public override double Price()
        {
            return 600000;
        }
    }
    public class Maruthi : CarBase//, ICar
    {
        public override double Price()
        {
            return 500000;
        }
    }

    #region abstract class
    public abstract class CarBase
    {
        public string Wheel()
        {
            return "4 Wheel";
        }

        public string AC()
        {
            return "AC is available";
        }

        public abstract double Price();


    }

    #endregion

    #region class

    //public class CarBase
    //{
    //    public string Wheel()
    //    {
    //        return "4 Wheel";
    //    }

    //    public string AC()
    //    {
    //        return "AC is available";
    //    }

    //    public virtual double Price()
    //    {
    //        return 40000;
    //    }
    //}

    #endregion
}
