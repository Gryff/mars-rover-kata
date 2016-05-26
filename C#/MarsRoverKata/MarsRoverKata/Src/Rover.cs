using System.Linq;

namespace MarsRoverKata.Src
{
    internal class Rover
    {
        private readonly Grid _grid;
        private GridPosition _position = new GridPosition(0, 0);
        private IDirection _direction = new North();

        public Rover(GridPosition obstacle = null)
        {
            this._grid = new Grid(10, 10, obstacle);
        }

        public string Move(string instructions)
        {
            try
            {
                instructions.ToList().ForEach(ExecuteInstruction);
            }
            catch (EncounteredObstacleException)
            {
                return $"O{ReportLocation()}";
            }

            return ReportLocation();
        }

        private void ExecuteInstruction(char instruction)
        {
            if (instruction == 'M')
                _position = _direction.MoveForwardFrom(_position, _grid);
            if (instruction == 'L')
                _direction = _direction.RotateLeft();
            if (instruction == 'R')
                _direction = _direction.RotateRight();
        }

        private string ReportLocation() =>
            $"{_position}{_direction.ToOutputFormat()}";
    }
}
