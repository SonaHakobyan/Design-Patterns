using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var objCarSupplier = CarFactory.GetCarInstance(3);
            objCarSupplier.GetCarModel();
            Console.WriteLine("And Coloar is " + objCarSupplier.CarColor);

            Console.ReadLine();
        }
    }
}
