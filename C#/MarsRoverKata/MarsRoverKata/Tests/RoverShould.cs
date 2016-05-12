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
        
        [TestCase("M", "01N")]
        [TestCase("MM", "02N")]
        public void Be_able_to_move_North(string instructions, string expectedPosition)
        {
            Assert.That(_rover.Move(instructions), Is.EqualTo(expectedPosition));
        }

        [TestCase("L", "00W")]
        [TestCase("LL", "00S")]
        [TestCase("LLL", "00E")]
        [TestCase("LLLL", "00N")]
        public void Be_able_to_rotate_left(string instructions, string expectedPosition)
        {
            Assert.That(_rover.Move(instructions), Is.EqualTo(expectedPosition));
        }

        [TestCase("R", "00E")]
        [TestCase("RR", "00S")]
        [TestCase("RRR", "00W")]
        [TestCase("RRRR", "00N")]
        public void Be_able_to_rotate_right(string instructions, string expectedPosition)
        {
            Assert.That(_rover.Move(instructions), Is.EqualTo(expectedPosition));
        }

        [TestCase("MMMMMMMMMM", "00N")]
        [TestCase("RMMMMMMMMMM", "00E")]
        [TestCase("LMMMMMMMMMM", "00W")]
        [TestCase("LLMMMMMMMMMM", "00S")]
        public void Wrap_around_grid_when_it_reaches_a_boundary(string instructions, string expectedPosition)
        {
            Assert.That(_rover.Move(instructions), Is.EqualTo(expectedPosition));
        }
    }
}
