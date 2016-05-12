using System.Linq;

namespace MarsRoverKata.Src
{
    class Rover
    {
        private readonly Grid _grid;
        private GridPosition _position = new GridPosition(0, 0);
        private IDirection _direction = new North();
        private bool _hasHitObstacle;

        public Rover(GridPosition obstacle = null)
        {
            this._grid = new Grid(10, 10, obstacle);
        }

        public string Move(string instructions)
        {
            instructions.ToList().ForEach(ExecuteInstruction);

            return $"{ReportObstacle()}{_position.ToOutputFormat()}{_direction.ToOutputFormat()}";
        }

        private void ExecuteInstruction(char instruction)
        {
            if (_hasHitObstacle) return;

            if (instruction == 'M')
                _position = CheckForObstacle(
                    _position, _direction.MoveForwardFrom(_position, _grid));
            if (instruction == 'L')
                _direction = _direction.RotateLeft();
            if (instruction == 'R')
                _direction = _direction.RotateRight();
        }

        private GridPosition CheckForObstacle(GridPosition position, GridPosition newPosition)
        {
            if (position.Equals(newPosition))
            {
                _hasHitObstacle = true;
                return position;
            }

            return newPosition;
        }

        private string ReportObstacle() =>
            _hasHitObstacle ? "O" : string.Empty;
    }
}
