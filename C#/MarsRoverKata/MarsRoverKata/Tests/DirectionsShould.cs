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
    }
}
