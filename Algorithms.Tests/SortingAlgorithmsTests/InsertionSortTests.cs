using Algorithms.SortingAlgorithms;

namespace Algorithms.Tests.SortingAlgorithmsTests
{
    [TestFixture]
    public class InsertionSortTests
    {
        [Test]
        public void Sort_AscendingOrder()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae" };
            string[] sortedNames = { "Evie", "Felix", "Heath", "Huerta", "Kira", "Mae", "Mohamed" };

            InsertionSort<string>.Sort(names, true);

            Assert.That(names, Is.EqualTo(sortedNames));
        }
        
        [Test]
        public void Sort_DescendingOrder()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae" };
            string[] sortedNames = { "Mohamed", "Mae", "Kira", "Huerta", "Heath", "Felix", "Evie" };

            InsertionSort<string>.Sort(names, false);

            Assert.That(names, Is.EqualTo(sortedNames));
        }
    }
}
