using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Patterns.Decorator
{
    public interface IPizza
    {
        double Cost { get; }
        string Description();
    }

    public class Pizza : IPizza
    {
        public Pizza(string description)
        {
            this._Description = description;
        }

        private string _Description;
        public string Description()
        {
            return _Description;
        }

        public double Cost
        {
            get { return 450.0; }
        }
    }

    public abstract class PizzaTopings : IPizza
    {
        protected IPizza _IPizza;

        public PizzaTopings(IPizza IPizza)
        {
            _IPizza = IPizza;
        }

        public abstract double Cost { get; }

        public abstract string Description();
    }

    public class ExtraSoya : PizzaTopings
    {
        public ExtraSoya(IPizza pizza) : base(pizza)
        {
            //_IPizza = pizza;
        }

        public override double Cost
        {
            get { return _IPizza.Cost + 50; }
        }

        public override string Description()
        {
            return _IPizza.Description() + " + Extra Soya";
        }
    }

    public class ExtraCheese : PizzaTopings
    {
        public ExtraCheese(IPizza pizza) : base(pizza)
        {
            //_IPizza = pizza;
        }

        public override double Cost
        {
            get { return _IPizza.Cost + 75; }
        }

        public override string Description()
        {
            return _IPizza.Description() + " + Extra Cheese";
        }
    }

    public class ExtraTomatoAndOnion : PizzaTopings
    {
        public ExtraTomatoAndOnion(IPizza pizza) : base(pizza)
        {
            //_IPizza = pizza;
        }

        public override double Cost
        {
            get { return _IPizza.Cost + 90; }
        }

        public override string Description()
        {
            return _IPizza.Description() + " + Extra Tomato & Onion";
        }
    }
    
}
