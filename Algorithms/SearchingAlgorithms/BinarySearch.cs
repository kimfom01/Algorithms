using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SearchingAlgorithms
{
    public class BinarySearch
    {
        public BinarySearch()
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
            int left, right, middle, key_pos;
            bool found;

            left = 0;
            right = Arr.Length - 1;
            found = false;
            key_pos = -1;
            while (left <= right && found == false)
            {
                middle = (int)((left + right) / 2);

                if (key < Arr[middle])
                {
                    right = middle - 1;
                }
                else if (key > Arr[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    found = true;
                    key_pos = middle;
                }
            }

            return key_pos;
        }
    }
}
