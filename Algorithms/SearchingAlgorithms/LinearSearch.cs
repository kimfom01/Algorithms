namespace Algorithms.SearchingAlgorithms
{
    public class LinearSearch<T>
    {
        /// <summary>
        /// Method to search for a given key from an array and specifying whether ascending or descending.
        /// </summary>
        /// <param name="arr">Array to search from.</param>
        /// <param name="key">Key to look for.</param>
        /// <returns>The index of the array if found, otherwise -1.</returns>
        public static int Search(T[] arr, T key)
        {
            int index = 0, size = arr.Length;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            while (index <= size - 1)
            {
                if (comparer.Equals(arr[index], key))
                    return index;
                index++;
            }

            return -1;
        }
    }
}
