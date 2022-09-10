using Algorithms.SearchingAlgorithms;

namespace Algorithms.Tests.SearchingAlgorithmsTests
{
    [TestFixture]
    public class LinearSearchTests
    {
        [Test]
        public void Search_KeyThatExists_ReturnsIndexOfKey()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae", "Legge", "Matthias", "Sims", "Muhammed", "Thatcher", "Nala", "Farrell", "Ozan", "Dejesus", "Talhah", "Summers", "Usaamah", "Hunter" };

            var result = LinearSearch<string>.Search(names, "Kira");

            Assert.That(result == 4);
        }

        [Test]
        public void Search_KeyThatDoesNotExist_ReturnsMinusOne()
        {
            string[] names = { "Evie", "Heath", "Felix", "Mohamed", "Kira", "Huerta", "Mae", "Legge", "Matthias", "Sims", "Muhammed", "Thatcher", "Nala", "Farrell", "Ozan", "Dejesus", "Talhah", "Summers", "Usaamah", "Hunter" };

            var result = LinearSearch<string>.Search(names, "Kim");

            Assert.That(result == -1);
        }
    }
}
