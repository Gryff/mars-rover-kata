using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class MarsRoverGameShould
    {
        private MarsRoverGame _marsRoverGame;

        [SetUp]
        public void SetUp()
        {
            _marsRoverGame = new MarsRoverGame();
        }

        [Test]
        public void Let_a_user_specify_grid_size()
        {
            _marsRoverGame.GenerateGrid(3, 3);

            Assert.AreEqual("3 3", _marsRoverGame.GetGridSize());
        }

        [Test]
        public void Let_a_user_specify_rover_location()
        {
            _marsRoverGame.GenerateGrid(10, 10);
            _marsRoverGame.SetRoverLocation(3, 4, 'S');

            Assert.AreEqual("3 4 S", _marsRoverGame.GetRoverLocation());
        }

        [Test]
        public void Move_rover_acording_to_user_instructions()
        {
            _marsRoverGame.GenerateGrid(10, 10);
            _marsRoverGame.SetRoverLocation(5, 5, 'W');
            _marsRoverGame.MoveRover("LMRMMMRMRRM");

            Assert.AreEqual("2 4 S", _marsRoverGame.GetRoverLocation());
        }
    }
}
