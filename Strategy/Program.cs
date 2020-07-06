using Strategy.CalculatingStrategies;
using Strategy.Strategies;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var packages = new List<Package>();

            packages.Add(new Package("A teddy bear"));
            packages.Add(new Package("A computer monitor"));
            packages.Add(new Package("Some salmon filets"));
            packages.Add(new Package("A massive teddy bear"));

            new DeliveryService(new FragileStrategy(), new AirCalculator()).Deliver(new Package("A computer monitor"));
            new DeliveryService(new DefaultStrategy(), new AirCalculator()).Deliver(new Package("A teddy bear"));
            new DeliveryService(new PerishableStrategy(), new AirCalculator()).Deliver(new Package("Some salmon filets"));
            new DeliveryService(new OversizedStrategy(), new AirCalculator()).Deliver(new Package("A massive teddy bear"));

            Console.ReadKey();
        }
    }
}
