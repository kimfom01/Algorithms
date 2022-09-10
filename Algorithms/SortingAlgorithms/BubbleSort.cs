namespace Algorithms.SortingAlgorithms
{
    public class BubbleSort<T>
    {
        /// <summary>
        /// Sorts a given array in a specified order.
        /// </summary>
        /// <param name="Arr">Array to sort.</param>
        /// <param name="ascending">Order in which to sort. Default is ascending order but when set to false the array will be sorted in descending order.</param>
        public static void Sort(T[] Arr, bool ascending = true)
        {
            int i, j, size = Arr.Length;
            bool madeSwaps;

            Comparer<T> comparer = Comparer<T>.Default;

            for (i = 1; i <= size - 1; i++)
            {
                madeSwaps = false;

                for (j = size - 1; j >= i; j--)
                {
                    if (ascending)
                    {
                        if (comparer.Compare(Arr[j - 1], Arr[j]) > 0)
                        {
                            BubbleSort<T>.Swap(Arr, j - 1, j);
                            madeSwaps = true;
                        }
                    }
                    else
                    {
                        if (comparer.Compare(Arr[j - 1], Arr[j]) < 0)
                        {
                            BubbleSort<T>.Swap(Arr, j - 1, j);
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
        /// <param name="Arr">Array to perform swap on.</param>
        /// <param name="m">Index of the first element to swap.</param>
        /// <param name="n">Index of second element to swap.</param>
        private static void Swap(T[] Arr, int m, int n)
        {
            T temp = Arr[m];
            Arr[m] = Arr[n];
            Arr[n] = temp;
        }
    }
}
