namespace MarsRoverKata.Src
{
    internal class South : IDirection
    {
        public IDirection RotateLeft() => new East();

        public IDirection RotateRight() => new West();

        public GridPosition MoveForwardFrom(GridPosition position, GridSize gridSize)
        {
            var newY = position.Y - 1;

            if (newY == -1)
                newY = gridSize.MaxHeight - 1;

            return new GridPosition(position.X, newY);
        }

        public char ToOutputFormat() => 'S';
    }
}