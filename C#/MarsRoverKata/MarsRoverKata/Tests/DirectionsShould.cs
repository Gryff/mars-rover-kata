using MarsRoverKata.Src;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    class DirectionsShould
    {
        [Test]
        public void Rotate_position_left()
        {
            var north = new North();
            Assert.That(north.RotateLeft(), Is.InstanceOf(typeof(West)));

            var east = new East();
            Assert.That(east.RotateLeft(), Is.InstanceOf(typeof(North)));

            var south = new South();
            Assert.That(south.RotateLeft(), Is.InstanceOf(typeof(East)));

            var west = new West();
            Assert.That(west.RotateLeft(), Is.InstanceOf(typeof(South)));
        }

        [Test]
        public void Rotate_position_right()
        {
            var north = new North();
            Assert.That(north.RotateRight(), Is.InstanceOf(typeof(East)));

            var east = new East();
            Assert.That(east.RotateRight(), Is.InstanceOf(typeof(South)));

            var south = new South();
            Assert.That(south.RotateRight(), Is.InstanceOf(typeof(West)));

            var west = new West();
            Assert.That(west.RotateRight(), Is.InstanceOf(typeof(North)));
        }

        [Test]
        public void Determine_GridPosition_to_move_to()
        {
            var startingPosition = new GridPosition(1, 1);
            var grid = new Grid(10,10);

            var north = new North();
            Assert.That(
                north.MoveForwardFrom(startingPosition, grid), 
                Is.EqualTo(new GridPosition(1, 2)));

            var east = new East();
            Assert.That(
                east.MoveForwardFrom(startingPosition, grid), 
                Is.EqualTo(new GridPosition(2, 1)));

            var south = new South();
            Assert.That(
                south.MoveForwardFrom(startingPosition, grid), 
                Is.EqualTo(new GridPosition(1, 0)));

            var west = new West();
            Assert.That(
                west.MoveForwardFrom(startingPosition, grid),
                Is.EqualTo(new GridPosition(0, 1)));
        }
    }
}
