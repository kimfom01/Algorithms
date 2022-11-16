using Algorithms.SortingAlgorithms;

namespace Algorithms.Tests.SortingAlgorithmsTests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void Sort_AscendingOrder()
        {
            int[] numbers = { 3, 2, 6, 9, 7, 5, 4, 8, 1 };
            int[] sortedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            int start = 0;
            int end = numbers.Length;
            QuickSort<int>.Sort(numbers, start, end);

            Assert.That(numbers, Is.EqualTo(sortedNumbers));
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
    }
}