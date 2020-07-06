namespace Adapter
{
    /// <summary>
    /// Defines ISorter interface
    /// </summary>
    interface ISorter
    {
        /// <summary>
        /// Sort the array of numbers
        /// </summary>
        /// <param name="numbers">The numbers</param>
        /// <returns>Sorted array</returns>
        public int[] Sort(int[] numbers);
    }
}
