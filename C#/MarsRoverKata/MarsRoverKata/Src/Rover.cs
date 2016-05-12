using System.Linq;

namespace MarsRoverKata.Src
{
    class Rover
    {
        private readonly Grid _grid = new Grid(10, 10);
        private GridPosition _position = new GridPosition(0, 0);
        private IDirection _direction = new North();

        public string Move(string instructions)
        {
            instructions.ToList().ForEach(ExecuteInstruction);

            return $"{_position.ToOutputFormat()}{_direction.ToOutputFormat()}";
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
    }
}
