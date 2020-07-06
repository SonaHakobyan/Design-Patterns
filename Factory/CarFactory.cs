using Factory.Factories;

namespace Factory
{
    static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                case 2:
                default:
                    return null;
            }
        }
    }
}
