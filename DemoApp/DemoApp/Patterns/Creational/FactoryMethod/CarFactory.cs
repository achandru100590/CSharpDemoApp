namespace DemoApp.Patterns.Creational.FactoryMethod
{
    public interface ICar
    {
        Car GetCar();
    }

    public class Nissan : ICar
    {
        public Car GetCar()
        {
            return new Car()
            {
                Model = 2020,
                Brand = "Nissan Rogu",
                Color = "Black",
                Price = 25000
            };
        }
    }

    public class Honda : ICar
    {
        public Car GetCar()
        {
            return new Car()
            {
                Model = 2020,
                Brand = "Honda Civic",
                Color = "Black",
                Price = 25000
            };
        }
    }

    public class CarFactory
    {
        public ICar GetCar(Brand brand)
        {
            ICar car = null;

            switch (brand)
            {
                case Brand.Nissan:
                    car = new Nissan();
                    break;

                case Brand.Honda:
                    car = new Honda();
                    break;

                default:
                    break;
            }

            return car;
        }
    }

    public class Car
    {
        public int Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Model : {Model}\nBrand : {Brand}\nColor : {Color}\nPrice : {Price}\n\n";
        }
    }

    public enum Brand
    {
        Nissan = 1,
        Honda
    }
}