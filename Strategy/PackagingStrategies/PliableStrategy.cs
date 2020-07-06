using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Strategy for pliable objects, such as clothing.
    /// Uses envelope and tape.
    /// </summary>
    public class PliableStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.Envelope);
            package.Materials.Add(PackingMaterial.Tape);
        }
    }
}
