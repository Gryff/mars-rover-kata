using MarsRoverKata.Src;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    class GridShould
    {
        [Test]
        public void Handle_moving_in_all_four_directions()
        {
            var grid = new Grid(10, 10);
            var position = new GridPosition(5, 5);
            Assert.That(
                grid.MoveNorth(position), 
                Is.EqualTo(new GridPosition(5, 6)));
        }
    }
}
