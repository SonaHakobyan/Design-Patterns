using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Strategy for oversized objects, such as furniture.
    /// Uses large box, foam, and tape.
    /// </summary>
    public class OversizedStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.LargeBox);
            package.Materials.Add(PackingMaterial.Foam);
            package.Materials.Add(PackingMaterial.Tape);
        }
    }
}
