using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class RoverShould
    {
        private Rover _rover;

        [Test]
        public void Have_a_default_location()
        {
            _rover = new Rover();

            Assert.AreEqual(_rover.GetLocation(), "0 0 N");
        }


        [Test]
        public void Let_a_user_set_a_location()
        {
            _rover = new Rover(3, 3, 'N');

            Assert.AreEqual("3 3 N", _rover.GetLocation());
        }

        [Test]
        public void Rotate_a_rover_left()
        {
            _rover = new Rover(3, 3, 'N');

            _rover.RotateLeft();
            Assert.AreEqual("3 3 W", _rover.GetLocation());

            _rover.RotateLeft();
            Assert.AreEqual("3 3 S", _rover.GetLocation());

            _rover.RotateLeft();
            Assert.AreEqual("3 3 E", _rover.GetLocation());

            _rover.RotateLeft();
            Assert.AreEqual("3 3 N", _rover.GetLocation());
        }

        [Test]
        public void Rotate_a_rover_right()
        {
            _rover = new Rover(3, 3, 'N');

            _rover.RotateRight();
            Assert.AreEqual("3 3 E", _rover.GetLocation());

            _rover.RotateRight();
            Assert.AreEqual("3 3 S", _rover.GetLocation());

            _rover.RotateRight();
            Assert.AreEqual("3 3 W", _rover.GetLocation());

            _rover.RotateRight();
            Assert.AreEqual("3 3 N", _rover.GetLocation());
        }

        [Test]
        public void Move_forward_in_correct_direction()
        {
            _rover = new Rover();

            _rover.MoveForward();
            Assert.AreEqual("0 1 N", _rover.GetLocation());

            _rover.MoveForward();
            Assert.AreEqual("0 2 N", _rover.GetLocation());

            _rover.RotateRight();
            _rover.MoveForward();
            Assert.AreEqual("1 2 E", _rover.GetLocation());

            _rover.RotateRight();
            _rover.MoveForward();
            Assert.AreEqual("1 1 S", _rover.GetLocation());

            _rover.RotateRight();
            _rover.MoveForward();
            Assert.AreEqual("0 1 W", _rover.GetLocation());
        }
    }
}
