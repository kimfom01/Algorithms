using Algorithms.SearchingAlgorithms;

namespace Algorithms.Tests.SearchingAlgorithmsTests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void Search_KeyThatExists_ReturnsIndexOfKey()
        {
            var numbers = new int[21]
            {
                5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25
            };

            var result = BinarySearch<int>.Search(numbers, 20);

            Assert.That(result == 15);
        }

        [Test]
        public void Search_KeyThatDoesNotExist_ReturnsMinusOne()
        {
            var numbers = new int[21]
            {
                5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25
            };

            var result = BinarySearch<int>.Search(numbers, 35);

            Assert.That(result == -1);
        }
    }
}
