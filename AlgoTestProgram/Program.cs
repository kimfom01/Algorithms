﻿using Algorithms.SortingAlgorithms;

namespace AlgoTestProgram
{
    internal class Program
    {
        const int ELEMENTS = 20;
        static void Main(string[] args)
        {
            int i;
            Random rnd = new Random();
            InsertionSort<int> stuff = new InsertionSort<int>();

            int[] arr = new int[ELEMENTS];

            for (i = 0; i <= ELEMENTS - 1; i++)
            {
                arr[i] = rnd.Next(20);
            }

            Console.Write("Before Sort: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            stuff.Sort(arr, false);

            Console.Write("After Sort: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}