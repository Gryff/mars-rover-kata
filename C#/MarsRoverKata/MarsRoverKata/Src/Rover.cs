namespace MarsRoverKata.Src
{
    class Rover
    {
        private int _x = 0;
        private int _y = 0;
        private IDirection _direction = new North();

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        MoveForward();
                    if (instruction == 'L')
                        _direction = _direction.RotateLeft();
                    if (instruction == 'R')
                        _direction = _direction.RotateRight();
                }
            }

            return $"{_x}{_y}{_direction.ToOutputFormat()}";
        }

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
