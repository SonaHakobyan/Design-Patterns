using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // init an array of numbers
            var numbers = new int[] { 34, 2, 4, 12, 1 };

            // an instance of sorter adapter
            var sorter = new SorterAdapter(new NumberSorter());

            // sort the array
            var sorted = sorter.Sort(numbers);

            Console.ReadKey();
        }
    }
}





