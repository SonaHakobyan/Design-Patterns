using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the Order/Product details
            var orderDetails = new OrderDetails("C# Design Pattern Book",
                                                         "Simplified book on design patterns in C#",
                                                         500,
                                                         10,
                                                         "Street No 1",
                                                         "Educational Area",
                                                         1212,
                                                         "4156213754"
                                                         );

            var facade = new OnlineShoppingFacade();
            facade.FinalizeOrder(orderDetails);

            Console.ReadLine();
        }
    }
}
