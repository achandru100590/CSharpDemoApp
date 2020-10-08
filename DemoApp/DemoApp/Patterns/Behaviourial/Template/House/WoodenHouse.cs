using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template.House
{
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
}
