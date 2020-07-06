using Strategy.Enums;

namespace Strategy.CalculatingStrategies
{
    public class AirCalculator : ICalculatingStrategy
    {
        public void CalculatePrice(Package package)
        {
            package.ShipmentMode = ShipmentMode.Air;
        }
    }
}
