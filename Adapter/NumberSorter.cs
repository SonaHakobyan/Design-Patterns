using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// The adaptee, a third party implementation of a 
    /// number sorter that deals with lists, not arrays
    /// </summary>
    public class NumberSorter
    {
        /// <summary>
        /// Sort list of numbers
        /// </summary>
        /// <param name="numbers">The numbers</param>
        /// <returns></returns>
        public List<int> Sort(List<int> numbers)
        {
            // sort numbers
            numbers.Sort();

            // return numbers
            return numbers;
        }
    }
}
