using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Strategy for fragile objects, such as glassware.
    /// Uses box, bubble wrap, foam, and tape.
    /// </summary>
    public class FragileStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.Box);
            package.Materials.Add(PackingMaterial.BubbleWrap);
            package.Materials.Add(PackingMaterial.Foam);
            package.Materials.Add(PackingMaterial.Tape);
        }
    }
}
