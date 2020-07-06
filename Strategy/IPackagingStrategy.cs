namespace Strategy
{
    /// <summary>
    /// Strategy interface used to pack all packages.
    /// </summary>
    public interface IMaterialsStrategy
    {
        void Pack(Package package);
    }
}

