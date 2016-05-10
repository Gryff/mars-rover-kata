using System.Collections.Generic;

namespace MarsRoverKata
{
    public class Rover
    {
        private int _x;
        private int _y;
        private char _direction;

        private readonly LinkedList<char> _directions = 
            new LinkedList<char>(
                new[]
                {
                    'N', 'E', 'S', 'W'
                });

        public Rover()
        {
            _x = 0;
            _y = 0;
            _direction = 'N';
        }

        public Rover(int x, int y, char direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public string GetLocation()
        {
            return $"{_x} {_y} {_direction}";
        }

        public void RotateLeft()
        {
            var currentDirection = _directions.Find(_direction);

            _direction = currentDirection.PreviousOrLast().Value;
        }

        public void RotateRight()
        {
            var currentDirection = _directions.Find(_direction);

            _direction = currentDirection.NextOrFirst().Value;
        }

        public void MoveForward()
        {
            if(_direction == 'N')
                _y += 1;

            if (_direction == 'E')
                _x += 1;

            if (_direction == 'S')
                _y -= 1;

            if (_direction == 'W')
                _x -= 1;
        }
    }
}