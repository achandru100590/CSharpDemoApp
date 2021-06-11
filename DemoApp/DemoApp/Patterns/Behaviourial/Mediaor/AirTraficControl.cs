using System;
using System.Collections.Generic;

namespace DemoApp.Patterns.Behaviourial.Mediaor
{
    public interface IAirTraficControlMediator
    {
        void Register(Flight flight);

        void SendMessage(Flight flight, string message);
    }

    public class AirTraficControlMediator : IAirTraficControlMediator
    {
        private List<Flight> flights = new List<Flight>();

        public void SendMessage(Flight flight, string message)
        {
            foreach (var f in flights)
            {
                if (flight != f)
                {
                    f.RecieveMessage(message);
                }
            }
        }

        public void Register(Flight flight)
        {
            flights.Add(flight);
        }
    }

    public abstract class Flight
    {
        protected IAirTraficControlMediator airTraficControlMediator;

        protected int flightNumber;

        public Flight(IAirTraficControlMediator airTraficControlMediator, int flightNumber)
        {
            this.airTraficControlMediator = airTraficControlMediator;
            this.flightNumber = flightNumber;
        }

        public abstract void SendMessage(string message);

        public abstract void RecieveMessage(string message);
    }

    public class ConreteFlight : Flight
    {
        public ConreteFlight(IAirTraficControlMediator airTraficControlMediator, int flighNumber) : base(airTraficControlMediator, flighNumber)
        {
        }

        public override void RecieveMessage(string message)
        {
            Console.WriteLine($"Message  {message} Recieved By {this.flightNumber}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"Sent Message by {this.flightNumber} : {message}");
            airTraficControlMediator.SendMessage(this, message);
        }
    }
}