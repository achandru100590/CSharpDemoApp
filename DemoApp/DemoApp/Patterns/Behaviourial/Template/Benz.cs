using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public class Benz : CarTemplate
    {
        protected override void Sceleton()
        {
            Console.WriteLine("Benz Car Sceleton Is Done");
        }
        protected override void InstallEngine()
        {
            Console.WriteLine("Benz Car Engin Installation Is Done");
        }

        protected override void InstallDoors()
        {
            Console.WriteLine("Benz Car Door Installation Is Done");
        }
        protected override void InstallTiers()
        {
            Console.WriteLine("Benz Car Tiers Installation Is Done");
        }
    }
}
