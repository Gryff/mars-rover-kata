namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft() => new North();

        public IDirection RotateRight() => new South();

        public GridPosition MoveForwardFrom(GridPosition position, GridSize gridSize)
        {
            var newX = position.X + 1;

            if (newX == gridSize.MaxWidth)
                newX = 0;

            return new GridPosition(newX, position.Y);
        }

        public char ToOutputFormat() => 'E';
    }
}