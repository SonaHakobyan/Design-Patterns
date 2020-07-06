using System;

namespace Factory.Factories
{
    class Honda : ICarSupplier
    {
        public string CarColor => "RED";

        public void GetCarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
}
