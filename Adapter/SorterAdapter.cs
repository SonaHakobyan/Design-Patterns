using System.Linq;

namespace Adapter
{
    /// <summary>
    /// The SorterAdapter adapts the interface of NumberSorter to ISorter
    /// </summary>
    public class SorterAdapter : ISorter
    {
        /// <summary>
        /// The adaptee
        /// </summary>
        private readonly NumberSorter sorter;

        /// <summary>
        /// Creates a new instance of SorterAdapter
        /// </summary>
        /// <param name="sorter"></param>
        public SorterAdapter(NumberSorter sorter)
        {
            this.sorter = sorter;
        }

        /// <summary>
        /// Sort the array of numbers using adaptee's interface
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>Sorted array</returns>
        public int[] Sort(int[] array)
        {
            //convert the array to the list
            var list = array.ToList();

            // call the adaptee's method      
            this.sorter.Sort(list);

            //convert the list back to an array and return             
            return list.ToArray();
        }
    }
}
