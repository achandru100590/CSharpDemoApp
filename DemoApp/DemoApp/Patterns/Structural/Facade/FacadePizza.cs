using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Facade
{
    public class Dough
    {
        public void PrepareDough()
        {
            Console.WriteLine("Dough is prepared.");
        }
    }
    public class Sauce
    {
        string _flavour;

        public Sauce(string flavour)
        {
            _flavour = flavour;
        }

        public void AddSauce()
        {
            Console.WriteLine("{0} sauce is added.", _flavour);
        }
    }
    public class Topping
    {
        string _flavour;

        public Topping(string flavour)
        {
            _flavour = flavour;
        }

        public void AddTopping()
        {
            Console.WriteLine("{0} topping is added.", _flavour);
        }
    }
    public class Cheese
    {
        string _flavour;

        public Cheese(string flavour)
        {
            _flavour = flavour;
        }

        public void AddCheese()
        {
            Console.WriteLine("{0} chees is added.", _flavour);
        }
    }    
    public class Oven
    {

        int _time;

        public Oven(int time)
        {
            _time = time;
        }

        public void OnOven()
        {
            Console.WriteLine("Pizza will be ready after {0} minutes.", _time);
        }
    }
    public class PizzaFacade
    {
        Dough _dough;
        Sauce _sauce;
        Topping _topping;
        Cheese _cheese;
        Oven _oven;

        public PizzaFacade(Dough dough, Sauce sauce, Topping topping, Cheese cheese, Oven oven)
        {
            _dough = dough;
            _sauce = sauce;
            _topping = topping;
            _cheese = cheese;
            _oven = oven;
        }

        public void MakePizza()
        {
            _dough.PrepareDough();
            _sauce.AddSauce();
            _topping.AddTopping();
            _cheese.AddCheese();
            _oven.OnOven();
        }
    }

}
