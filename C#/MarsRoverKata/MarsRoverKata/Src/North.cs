namespace MarsRoverKata.Src
{
    internal class North : IDirection
    {
        public IDirection RotateLeft() => new West();

        public IDirection RotateRight() => new East();

        public GridPosition MoveForwardFrom(GridPosition position, Grid grid) =>
            grid.MoveNorth(position);

        public override string ToString() => "N";

        public char ToOutputFormat() => 'N';
    }
}
