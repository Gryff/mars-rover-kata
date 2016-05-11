namespace MarsRoverKata.Src
{
    class North : IDirection
    {
        public IDirection RotateLeft() => new West();

        public IDirection RotateRight() => new East();

        public GridPosition MoveForwardFrom(GridPosition position) =>
            new GridPosition(position.X, position.Y + 1);

        public char ToOutputFormat() => 'N';
    }
}
