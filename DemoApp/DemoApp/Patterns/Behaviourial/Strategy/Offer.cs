using System;

namespace DemoApp.Patterns.Behaviourial.Strategy
{
    public interface IOfferStrategy
    {
        void Offer();
    }

    public class WeekDaysOffer : IOfferStrategy
    {
        public void Offer()
        {
            Console.WriteLine("you are eligible for 5% offer !!!");
        }
    }

    public class WeekendOffer : IOfferStrategy
    {
        public void Offer()
        {
            Console.WriteLine("you are eligible for 10% offer !!!");
        }
    }
}