namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft() => new South();

        public IDirection RotateRight() => new North();

        public GridPosition MoveForwardFrom(GridPosition position) =>
            new GridPosition(position.X - 1, position.Y);

        public char ToOutputFormat() => 'W';
    }
}
