using System.Linq;

namespace MarsRoverKata.Src
{
    class Rover
    {
        private readonly GridSize _gridSize = new GridSize(10, 10);
        private GridPosition _position = new GridPosition(0, 0);
        private IDirection _direction = new North();

        public string Move(string instructions = null)
        {
            instructions?.ToList().ForEach(ExecuteInstruction);

            return $"{_position.ToOutputFormat()}{_direction.ToOutputFormat()}";
        }

        private void ExecuteInstruction(char instruction)
        {
            if (instruction == 'M')
                _position = _direction.MoveForwardFrom(_position, _gridSize);
            if (instruction == 'L')
                _direction = _direction.RotateLeft();
            if (instruction == 'R')
                _direction = _direction.RotateRight();
        }
    }
}
