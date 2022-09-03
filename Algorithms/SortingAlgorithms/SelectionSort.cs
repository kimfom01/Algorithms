namespace Algorithms.SortingAlgorithms
{
    public class SelectionSort<T>
    {
        /// <summary>
        /// Sorts a given array in a specified order.
        /// </summary>
        /// <param name="Arr">Array to sort.</param>
        /// <param name="ascending">Order in which to sort. Default is ascending order but when set to false the array will be sorted in descending order.</param>
        public void Sort(T[] Arr, bool ascending = true)
        {
            int i, j, size = Arr.Length, min_max_index;
            T minimum;

            Comparer<T> comparer = Comparer<T>.Default;

            for (i = 0; i <= size - 1; i++)
            {
                min_max_index = i;
                for (j = i; j <= size - 1; j++)
                {
                    if (ascending)
                    {
                        if (comparer.Compare(Arr[j], Arr[min_max_index]) < 0)
                        {
                            min_max_index = j;
                        } 
                    }
                    else
                    {
                        if (comparer.Compare(Arr[j], Arr[min_max_index]) > 0)
                        {
                            min_max_index = j;
                        }
                    }
                }

                SelectionSort<T>.Swap(Arr, i, min_max_index);
            }
        }

        private static void Swap(T[] Arr, int m, int n)
        {
            T temp = Arr[m];
            Arr[m] = Arr[n];
            Arr[n] = temp;
        }
    }
}
