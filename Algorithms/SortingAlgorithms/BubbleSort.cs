namespace Algorithms.SortingAlgorithms
{
    public class BubbleSort<T>
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
                var madeSwaps = false;

                int j;
                for (j = size - 1; j >= i; j--)
                {
                    if (ascending)
                    {
                        if (comparer.Compare(arr[j - 1], arr[j]) > 0)
                        {
                            BubbleSort<T>.Swap(arr, j - 1, j);
                            madeSwaps = true;
                        }
                    }
                    else
                    {
                        if (comparer.Compare(arr[j - 1], arr[j]) < 0)
                        {
                            BubbleSort<T>.Swap(arr, j - 1, j);
                            madeSwaps = true;
                        }
                    }
                }

                if (!madeSwaps)
                {
                    break;
                }

            }
        }

        /// <summary>
        /// Swaps two elements in an array.
        /// </summary>
        /// <param name="arr">Array to perform swap on.</param>
        /// <param name="m">Index of the first element to swap.</param>
        /// <param name="n">Index of second element to swap.</param>
        private static void Swap(T[] arr, int m, int n)
        {
            T temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }
    }
}
