namespace MarsRoverKata.Src
{
    class Rover
    {
        private int _x = 0;
        private int _y = 0;
        private char _direction = 'N';

        public string Move(string instructions = null)
        {
            if(instructions != null)
                _y += 1;

            return $"{_x}{_y}{_direction}";
        }
    }
}
