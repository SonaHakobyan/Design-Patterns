using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Strategy for flat objects, such as letters.
    /// Uses envelope.
    /// </summary>
    public class FlatStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.Envelope);
        }
    }
}
