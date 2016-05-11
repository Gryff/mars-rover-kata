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
                        RotateLeft();
                }
            }

            return $"{_x}{_y}{_direction}";
        }

        private void RotateLeft()
        {
            _direction = 'W';
        }

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
