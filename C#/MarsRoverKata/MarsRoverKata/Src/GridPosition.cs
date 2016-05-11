namespace MarsRoverKata.Src
{
    class GridPosition
    {
        public int X;
        public int Y;

        public GridPosition(int x, int y)
        {
            Y = y;
            X = x;
        }

        public string ToOutputFormat() => $"{X}{Y}";
    }
}
