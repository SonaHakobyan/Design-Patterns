using Strategy.Enums;

namespace Strategy.Strategies
{
    /// <summary>
    /// Strategy for perishables, such as food.
    /// Uses box, dry ice, foam, and tape.
    /// </summary>
    public class PerishableStrategy : IMaterialsStrategy
    {
        public void Pack(Package package)
        {
            package.Materials.Add(PackingMaterial.Box);
            package.Materials.Add(PackingMaterial.DryIce);
            package.Materials.Add(PackingMaterial.Foam);
            package.Materials.Add(PackingMaterial.Tape);
        }
    }
}
