using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Creational.Factory
{
    public interface IAnimal
    {
        string Speak();
    }

    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Miaaum";
        }
    }

    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Lolle Lolle";
        }
    }

    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }

    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "Ushshshsh Ushshshsh";
        }
    }

    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Augh Augh";
        }
    }    

    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            IAnimal objAnimal;

            switch (animal)
            {
                case Animal.Cat:
                    objAnimal = new Cat();
                    break;
                case Animal.Dog:
                    objAnimal = new Dog();
                    break;
                case Animal.Lion:
                    objAnimal = new Lion();
                    break;
                default:
                    objAnimal = null;
                    break;
            }

            return objAnimal;
        }
    }

    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            IAnimal objAnimal;

            switch (animal)
            {
                case Animal.Shark:
                    objAnimal = new Shark();
                    break;
                case Animal.Octopus:
                    objAnimal = new Octopus();
                    break;
                default:
                    objAnimal = null;
                    break;
            }

            return objAnimal;
        }
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(Animal animal);

        public static AnimalFactory GetAnimalFactory(AnimalType animalType)
        {
            AnimalFactory animalFactory = null;
            switch (animalType)
            {
                case AnimalType.Land:
                    animalFactory = new LandAnimalFactory();
                    break;
                case AnimalType.Sea:
                    animalFactory = new SeaAnimalFactory();
                    break;
                default:
                    return animalFactory;
            }

            return animalFactory;
        }
    }


    public enum Animal
    {
        Cat = 1,
        Dog,
        Lion,
        Octopus,
        Shark
    }
    public enum AnimalType
    {
        Land = 1,
        Sea
    }


}
