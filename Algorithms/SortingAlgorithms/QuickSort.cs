namespace Algorithms.SortingAlgorithms;

public class QuickSort<T>
{
    private static readonly Comparer<T> Comparer = Comparer<T>.Default;

    public static void Sort(T[] arr, int start, int end, bool ascending = true)
    {
        if (start >= end) 
            return;
        int pivotIndex = Pivot(arr, start, end, ascending);

        // Sort left side
        Sort(arr, start, pivotIndex - 1, ascending);

        // Sort right side
        Sort(arr, pivotIndex + 1, end, ascending);
    }

    private static int Pivot(T[] arr, int start, int end, bool ascending = true)
    {
        T pivot = arr[start];
        int swapIndex = start;

        for (int i = start; i <= end - 1; i++)
        {
            if (ascending && Comparer.Compare(pivot, arr[i]) > 0)
            {
                swapIndex++;
                Swap(arr, swapIndex, i);
            }
            else if (!ascending && Comparer.Compare(pivot, arr[i]) < 0)
            {
                swapIndex++;
                Swap(arr, swapIndex, i);
            }
        }

        Swap(arr, start, swapIndex);

        return swapIndex;
    }

    private static void Swap(T[] arr, int m, int n)
    {
        T temp = arr[m];
        arr[m] = arr[n];
        arr[n] = temp;
    }
}