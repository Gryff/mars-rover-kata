using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class GridShould
    {
        [Test]
        public void Tell_me_its_size()
        {
            var grid = new Grid(3, 3);

            Assert.AreEqual("3 3", grid.ToOutputFormat());
        }
    }
}
