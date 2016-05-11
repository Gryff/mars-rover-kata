using MarsRoverKata.Src;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    class RoverShould
    {
        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
        }

        [Test]
        public void Start_in_south_west_corner_facing_right()
        {
            Assert.That(_rover.Move(), Is.EqualTo("00N"));
        }


        [Test]
        public void Be_able_to_move_North()
        {
            Assert.That(_rover.Move("M"), Is.EqualTo("01N"));
            Assert.That(_rover.Move("M"), Is.EqualTo("02N"));
        }
    }
}
