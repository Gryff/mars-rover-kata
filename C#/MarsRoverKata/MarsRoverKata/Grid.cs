namespace MarsRoverKata
{
    internal class Grid
    {
        private readonly int _x;
        private readonly int _y;

        public Grid(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public string ToOutputFormat()
        {
            return $"{_x} {_y}";
        }
    }
}