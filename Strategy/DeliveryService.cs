using System;

namespace Strategy
{
    /// <summary>
    /// Client that routes all packages to the passed Materials strategy.
    /// </summary>
    public class DeliveryService
    {
        /// <summary>
        /// Materials strategy identifier
        /// </summary>
        private IMaterialsStrategy packager;
        private ICalculatingStrategy calculator;

        public DeliveryService(IMaterialsStrategy packager, ICalculatingStrategy calculator)
        {
            this.packager = packager;
            this.calculator = calculator;
        }

        public void Deliver(Package package)
        {
            this.packager.Pack(package);
            this.calculator.CalculatePrice(package);

            this.Ship(package);
        }

        private void Ship(Package package)
        {
            Console.WriteLine(package);
        }
    }
}
