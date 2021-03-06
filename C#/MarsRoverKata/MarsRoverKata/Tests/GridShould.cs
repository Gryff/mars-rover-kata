﻿using MarsRoverKata.Src;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    class GridShould
    {
        private Grid _grid;

        [SetUp]
        public void SetUp()
        {
            _grid = new Grid(10, 10);
        }

        [Test]
        public void Handle_moving_in_all_four_directions()
        {
            var position = new GridPosition(5, 5);

            Assert.That(
                _grid.MoveNorth(position), 
                Is.EqualTo(new GridPosition(5, 6)));

            Assert.That(
                _grid.MoveEast(position), 
                Is.EqualTo(new GridPosition(6, 5)));

            Assert.That(
                _grid.MoveSouth(position), 
                Is.EqualTo(new GridPosition(5, 4)));

            Assert.That(
                _grid.MoveWest(position), 
                Is.EqualTo(new GridPosition(4, 5)));
        }
        [Test]
        public void Wrap_position_around_if_Grid_boundary_is_exceeded()
        {
            var position = new GridPosition(9, 9);

            Assert.That(
                _grid.MoveNorth(position), 
                Is.EqualTo(new GridPosition(9, 0)));

            Assert.That(
                _grid.MoveEast(position),
                Is.EqualTo(new GridPosition(0, 9)));

            position = new GridPosition(0, 0);

            Assert.That(
                _grid.MoveSouth(position),
                Is.EqualTo(new GridPosition(0, 9)));

            Assert.That(
                _grid.MoveWest(position),
                Is.EqualTo(new GridPosition(9, 0)));
        }

        [Test]
        public void Throw_an_Exception_if_obstacle_is_in_the_way()
        {
            var obstacle = new GridPosition(0, 1);
            _grid = new Grid(10, 10, obstacle);
            var position = new GridPosition(0, 0);

            Assert.Throws<EncounteredObstacleException>(
                () => _grid.MoveNorth(position));
        }

        [Test]
        public void Return_original_unwrapped_position_if_obstacle_is_in_the_way()
        {
            var obstacle = new GridPosition(0, 0);
            _grid = new Grid(10, 10, obstacle);
            var position = new GridPosition(9, 0);

            Assert.Throws<EncounteredObstacleException>(
                () => _grid.MoveEast(position));
        }
    }
}
