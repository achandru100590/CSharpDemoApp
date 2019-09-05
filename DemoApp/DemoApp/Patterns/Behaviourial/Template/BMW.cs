using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public class BMW : CarTemplate
    {
        protected override void Sceleton()
        {
            Console.WriteLine("BMW Car Sceleton Is Done");
        }
        protected override void InstallEngine()
        {
            Console.WriteLine("BMW Car Engin Installation Is Done");
        }

        protected override void InstallDoors()
        {
            Console.WriteLine("BMW Car Door Installation Is Done");
        }
        protected override void InstallTiers()
        {
            Console.WriteLine("BMW Car Tiers Installation Is Done");
        }
    }
}
