using System;

namespace DemoApp.Patterns.Behaviourial.Strategy
{
    public class WeekDaysOffer : IOfferStrategy
    {
        public void Offer()
        {
            Console.WriteLine("you are eligible for 5% offer !!!");
        }
    }
}
