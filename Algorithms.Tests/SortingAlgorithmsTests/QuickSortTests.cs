using Algorithms.SortingAlgorithms;

namespace Algorithms.Tests.SortingAlgorithmsTests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void Sort_AscendingOrder([Random(0, 100, 10, Distinct = true)] int n)
        { // Failing test need to refactor code
            var (actual, expected) = GetArrays(n);

            int start = 0;
            int end = actual.Length;
            QuickSort<int>.Sort(actual, start, end);
            Array.Sort(expected);

            Assert.AreEqual(actual, expected);
        }
        
        [Test]
        public void Sort_DescendingOrder()
        {
            int[] numbers = { 3, 2, 6, 9, 7, 5, 4, 8, 1 };
            int[] sortedNumbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int start = 0;
            int end = numbers.Length;

            QuickSort<int>.Sort(numbers, start, end, false);

            Assert.That(numbers, Is.EqualTo(sortedNumbers));
        }
        
        private (int[] actual, int[] expected) GetArrays(int n)
        {
            var actual = new int[n];
            var expectedArray = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                int randNum = Random.Shared.Next(100);
                actual[i] = randNum;
                expectedArray[i] = randNum;
            }

            return (actual, expectedArray);
        }
    }
}