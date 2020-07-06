using System;

namespace Factory.Factories
{
    class BMW : ICarSupplier
    {
        public string CarColor => "WHITE";
        public void GetCarModel()
        {
            Console.WriteLine("BMW Car Model is BMW 2000");
        }
    }
}
