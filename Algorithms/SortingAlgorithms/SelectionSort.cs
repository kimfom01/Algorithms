namespace Algorithms.SortingAlgorithms
{
    public class SelectionSort<T>
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

            for (i = 0; i <= size - 1; i++)
            {
                var minMaxIndex = i;
                int j;
                for (j = i; j <= size - 1; j++)
                {
                    if (ascending)
                    {
                        if (comparer.Compare(arr[j], arr[minMaxIndex]) < 0)
                        {
                            minMaxIndex = j;
                        } 
                    }
                    else
                    {
                        if (comparer.Compare(arr[j], arr[minMaxIndex]) > 0)
                        {
                            minMaxIndex = j;
                        }
                    }
                }

                SelectionSort<T>.Swap(arr, i, minMaxIndex);
            }
        }

        private static void Swap(T[] arr, int m, int n)
        {
            T temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }
    }
}
