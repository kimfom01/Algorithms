namespace Algorithms.SortingAlgorithms
{
    public class InsertionSort<T>
    {
        /// <summary>
        /// Sorts a given array in a specified order.
        /// </summary>
        /// <param name="Arr">Array to sort.</param>
        /// <param name="ascending">Order in which to sort. Default is ascending order but when set to false the array will be sorted in descending order.</param>
        public static void Sort(T[] Arr, bool ascending = true)
        {
            int i, j, size = Arr.Length;
            T element;

            Comparer<T> comparer = Comparer<T>.Default;

            for (i = 1; i <= size - 1; i++)
            {
                element = Arr[i];

                j = i;
                if (ascending)
                {
                    while (j > 0 && comparer.Compare(Arr[j - 1], element) > 0)
                    {
                        Arr[j] = Arr[j - 1];
                        j--;
                    }
                }
                else
                {
                    while (j > 0 && comparer.Compare(Arr[j - 1], element) < 0)
                    {
                        Arr[j] = Arr[j - 1];
                        j--;
                    }
                }

                Arr[j] = element;
            }
        }
    }
}
