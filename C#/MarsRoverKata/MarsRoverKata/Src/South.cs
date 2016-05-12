namespace MarsRoverKata.Src
{
    internal class South : IDirection
    {
        public IDirection RotateLeft() => new East();

        public IDirection RotateRight() => new West();

        public GridPosition MoveForwardFrom(GridPosition position, Grid grid) =>
            grid.MoveSouth(position);

        public char ToOutputFormat() => 'S';
    }
}