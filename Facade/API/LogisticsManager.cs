using System;

namespace Facade.API
{
    public class LogisticsManager : ILogistics
    {
        public void ShipProduct(string product, string address)
        {
            Console.WriteLine($"Congratulations your product {product} has been shipped at the following address: { address} ");
        }
    }
}
