namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft() => new North();

        public IDirection RotateRight() => new South();

        public GridPosition MoveForwardFrom(GridPosition position, Grid grid) =>
            grid.MoveEast(position);

        public char ToOutputFormat() => 'E';
    }
}