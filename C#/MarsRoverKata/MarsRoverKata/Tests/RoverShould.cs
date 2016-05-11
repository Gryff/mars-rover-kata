using MarsRoverKata.Src;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    class RoverShould
    {
        [Test]
        public void Start_in_south_west_corner_facing_right()
        {
            var rover = new Rover();

            Assert.That(rover.Move(), Is.EqualTo("00N"));
        }
    }
}
