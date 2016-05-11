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
    }
}
