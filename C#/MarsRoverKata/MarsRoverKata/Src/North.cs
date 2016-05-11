namespace MarsRoverKata.Src
{
    class North : IDirection
    {
        public IDirection RotateLeft() => new West();

        public IDirection RotateRight() => new East();

        public GridPosition MoveForwardFrom(GridPosition position, GridSize gridSize)
        {
            var newY = position.Y + 1;

            if (newY == gridSize.MaxHeight)
                newY = 0;

            return new GridPosition(position.X, newY);
        }

        public char ToOutputFormat() => 'N';
    }
}
