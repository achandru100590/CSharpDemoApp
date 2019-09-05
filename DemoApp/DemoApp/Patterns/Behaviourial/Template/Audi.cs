using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public class Audi : CarTemplate
    {
        protected override void Sceleton()
        {
            Console.WriteLine("Audi Car Sceleton Is Done");
        }
        protected override void InstallEngine()
        {
            Console.WriteLine("Audi Car Engin Installation Is Done");
        }

        protected override void InstallDoors()
        {
            Console.WriteLine("Audi Car Door Installation Is Done");
        }
        protected override void InstallTiers()
        {
            Console.WriteLine("Audi Car Tiers Installation Is Done");
        }
    }
}
