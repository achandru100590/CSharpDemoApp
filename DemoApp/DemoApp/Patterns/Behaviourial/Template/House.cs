using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public class GlassHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Glass Foundation is completed");
        }

        protected override void BuildFWindows()
        {
            Console.WriteLine("Glass Windows are installed");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Glass Pillars are completed");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Glass Walls are Completed");
        }
    }

    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Wooden Foundation is completed");
        }

        protected override void BuildFWindows()
        {
            Console.WriteLine("Wooden Windows are installed");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Wooden Pillars are completed");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Wooden Walls are Completed");
        }
    }

    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildFWindows();
        }

        protected abstract void BuildFoundation();

        protected abstract void BuildPillars();

        protected abstract void BuildWalls();

        protected abstract void BuildFWindows();
    }
}