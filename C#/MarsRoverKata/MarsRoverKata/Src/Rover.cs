namespace MarsRoverKata.Src
{
    class Rover
    {
        private int _x = 0;
        private int _y = 0;
        private char _direction = 'N';

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        MoveForward();
                    if (instruction == 'L')
                        _direction = RotateLeft(_direction);
                }
            }

            return $"{_x}{_y}{_direction}";
        }

        private char RotateLeft(char direction)
        {
            if(direction == 'N')
                return 'W';
            if(direction == 'E')
                return 'N';
            if(direction == 'S')
                return 'E';
            if(direction == 'W')
                return 'S';

            return char.MinValue;
        }

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
