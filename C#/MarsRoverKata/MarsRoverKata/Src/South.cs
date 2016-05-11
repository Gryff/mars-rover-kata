namespace MarsRoverKata.Src
{
    internal class South : IDirection
    {
        public IDirection RotateLeft() => new East();

        public IDirection RotateRight() => new West();

        public GridPosition MoveForwardFrom(GridPosition position) =>
            new GridPosition(position.X, position.Y - 1);

        public char ToOutputFormat() => 'S';
    }
}