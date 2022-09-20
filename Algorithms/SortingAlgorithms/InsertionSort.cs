namespace Algorithms.SortingAlgorithms
{
    public class InsertionSort<T>
    {
        /// <summary>
        /// Sorts a given array in a specified order.
        /// </summary>
        /// <param name="arr">Array to sort.</param>
        /// <param name="ascending">Order in which to sort. Default is ascending order but when set to false the array will be sorted in descending order.</param>
        public static void Sort(T[] arr, bool ascending = true)
        {
            int i;
            int size = arr.Length;

            Comparer<T> comparer = Comparer<T>.Default;

            for (i = 1; i <= size - 1; i++)
            {
                var element = arr[i];

                var j = i;
                if (ascending)
                {
                    while (j > 0 && comparer.Compare(arr[j - 1], element) > 0)
                    {
                        arr[j] = arr[j - 1];
                        j--;
                    }
                }
                else
                {
                    while (j > 0 && comparer.Compare(arr[j - 1], element) < 0)
                    {
                        arr[j] = arr[j - 1];
                        j--;
                    }
                }

                arr[j] = element;
            }
        }
    }
}
