using Algorithms.SortingAlgorithms;

namespace Algorithms.Tests.SortingAlgorithmsTests
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void Sort_AscendingOrder()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae" };
            string[] sortedNames = { "Evie", "Felix", "Heath", "Huerta", "Kira", "Mae", "Mohamed" };

            SelectionSort<string>.Sort(names);

            Assert.That(names, Is.EqualTo(sortedNames));
        }

        [Test]
        public void Sort_DescendingOrder()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae" };
            string[] sortedNames = { "Mohamed", "Mae", "Kira", "Huerta", "Heath", "Felix", "Evie" };

            SelectionSort<string>.Sort(names, false);

            Assert.That(names, Is.EqualTo(sortedNames));
        }
    }
}
