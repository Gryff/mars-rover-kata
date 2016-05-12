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
            Assert.That(_rover.Move(""), Is.EqualTo("00N"));
        }
        
        [Test]
        public void Be_able_to_move_North()
        {
            Assert.That(_rover.Move("M"), Is.EqualTo("01N"));
            Assert.That(_rover.Move("M"), Is.EqualTo("02N"));
        }

        [Test]
        public void Be_able_to_rotate_left()
        {
            Assert.That(_rover.Move("L"), Is.EqualTo("00W"));
            Assert.That(_rover.Move("L"), Is.EqualTo("00S"));
            Assert.That(_rover.Move("L"), Is.EqualTo("00E"));
            Assert.That(_rover.Move("L"), Is.EqualTo("00N"));
        }

        [Test]
        public void Be_able_to_rotate_right()
        {
            Assert.That(_rover.Move("R"), Is.EqualTo("00E"));
            Assert.That(_rover.Move("R"), Is.EqualTo("00S"));
            Assert.That(_rover.Move("R"), Is.EqualTo("00W"));
            Assert.That(_rover.Move("R"), Is.EqualTo("00N"));
        }

        [Test]
        public void Wrap_around_grid_when_it_reaches_a_boundary()
        {
            Assert.That(_rover.Move("MMMMMMMMMM"), Is.EqualTo("00N"));
            Assert.That(_rover.Move("RMMMMMMMMMM"), Is.EqualTo("00E"));
            Assert.That(_rover.Move("LLMMMMMMMMMM"), Is.EqualTo("00W"));
            Assert.That(_rover.Move("LMMMMMMMMMM"), Is.EqualTo("00S"));
        }
    }
}
