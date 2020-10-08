using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template.House
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
}
