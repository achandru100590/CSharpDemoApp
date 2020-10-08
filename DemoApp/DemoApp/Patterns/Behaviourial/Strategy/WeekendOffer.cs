using System;

namespace DemoApp.Patterns.Behaviourial.Strategy
{
    public class WeekendOffer : IOfferStrategy
    {
        public void Offer()
        {
            Console.WriteLine("you are eligible for 10% offer !!!");
        }
    }
}
