using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SearchingAlgorithms
{
    public class LinearSearch<T>
    {
        /// <summary>
        /// Method to search for a given key from an array and specifying whether ascending or descending.
        /// </summary>
        /// <param name="Arr">Array to search from.</param>
        /// <param name="key">Key to look for.</param>
        /// <returns>The index of the array if found, otherwise -1.</returns>
        public static int Search(T[] Arr, T key)
        {
            int index = 0, size = Arr.Length;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            while (index <= size - 1 && !comparer.Equals(Arr[index], key))
            {
                index++;
            }

            if (!comparer.Equals(Arr[index], key))
            {
                return -1;
            }
            
            return index;
        }
    }
}
