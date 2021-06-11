using System;

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

    public abstract class CarTemplate
    {
        public void BuildCare()
        {
            Sceleton();
            InstallEngine();
            InstallDoors();
            InstallTiers();
        }

        protected abstract void Sceleton();

        protected abstract void InstallEngine();

        protected abstract void InstallDoors();

        protected abstract void InstallTiers();
    }
}