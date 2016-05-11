namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft() => new North();

        public IDirection RotateRight() => new South();

        public GridPosition MoveForwardFrom(GridPosition position) =>
            new GridPosition(position.X + 1, position.Y);

        public char ToOutputFormat() => 'E';
    }
}