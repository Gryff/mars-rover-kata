namespace MarsRoverKata.Src
{
    class Rover
    {
        private GridPosition _position = new GridPosition(0, 0);
        private IDirection _direction = new North();

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        _position = _direction.MoveForwardFrom(_position);
                    if (instruction == 'L')
                        _direction = _direction.RotateLeft();
                    if (instruction == 'R')
                        _direction = _direction.RotateRight();
                }
            }

            return $"{_position.ToOutputFormat()}{_direction.ToOutputFormat()}";
        }
    }
}
