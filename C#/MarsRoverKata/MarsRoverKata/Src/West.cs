namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft() => new South();

        public IDirection RotateRight() => new North();

        public GridPosition MoveForwardFrom(GridPosition position, Grid grid) =>
            grid.MoveWest(position);

        public char ToOutputFormat() => 'W';
    }
}
