using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SearchingAlgorithms
{
    public class LinearSearch
    {
        public LinearSearch()
        {

        }

        /// <summary>
        /// Method to search for a given key from an array and specifying whether ascending or descending
        /// </summary>
        /// <param name="Arr">Array to search from</param>
        /// <param name="key">key to look for</param>
        /// <returns>the index of the array if found else -1</returns>
        public double Search(double[] Arr, double key)
        {
            int i, size;

            i = 0;
            size = Arr.Length;
            while (i <= size - 1 && Arr[i] != key)
            {
                i++;
            }

            if (Arr[i] == key)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
