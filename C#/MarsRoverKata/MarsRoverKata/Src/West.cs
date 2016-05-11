namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft() => new South();

        public IDirection RotateRight() => new North();

        public GridPosition MoveForwardFrom(GridPosition position, GridSize gridSize)
        {
            var newX = position.X - 1;

            if (newX == -1)
                newX = gridSize.MaxWidth - 1;

            return new GridPosition(newX, position.Y);
        }

        public char ToOutputFormat() => 'W';
    }
}
