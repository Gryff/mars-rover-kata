namespace MarsRoverKata.Src
{
    internal class GridPosition
    {
        public readonly int X;
        public readonly int Y;

        public GridPosition(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }

        public override string ToString() => $"{X}{Y}";

        public override bool Equals(object obj)
        {
            var position = obj as GridPosition;

            if (position == null)
                return false;

            return this.X == position.X && this.Y == position.Y;
        }
    }
}
