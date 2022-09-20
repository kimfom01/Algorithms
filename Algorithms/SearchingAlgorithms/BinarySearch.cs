namespace Algorithms.SearchingAlgorithms
{
    public class BinarySearch<T>
    {
        /// <summary>
        /// Method to search for a given key from an array and specifying whether ascending or descending
        /// </summary>
        /// <param name="arr">Array to search from.</param>
        /// <param name="key">Key to look for.</param>
        /// <returns>The index of the array if found, otherwise -1.</returns>
        public static int Search(T[] arr, T key)
        {
            int left = 0, right = arr.Length - 1;
            int keyPos = -1;
            bool found = false;

            Comparer<T> comparer = Comparer<T>.Default;

            while (left <= right && found == false)
            {
                var middle = (left + right) / 2;

                if (comparer.Compare(key, arr[middle]) < 0)
                {
                    right = middle - 1;
                }
                else if (comparer.Compare(key, arr[middle]) > 0)
                {
                    left = middle + 1;
                }
                else
                {
                    found = true;
                    keyPos = middle;
                }
            }

            return keyPos;
        }
    }
}
