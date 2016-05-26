namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft() => new North();

        public IDirection RotateRight() => new South();

        public GridPosition MoveForwardFrom(GridPosition position, Grid grid) =>
            grid.MoveEast(position);

        public override string ToString() => "E";

        public char ToOutputFormat() => 'E';
    }
}