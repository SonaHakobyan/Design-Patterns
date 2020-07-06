using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Default Materials strategy.
    /// Uses box, bubble wrap, and tape.
    /// </summary>
    public class DefaultStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.Box);
            package.Materials.Add(PackingMaterial.BubbleWrap);
            package.Materials.Add(PackingMaterial.Tape);
        }
    }
}
