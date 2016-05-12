namespace MarsRoverKata.Src
{
    class Grid
    {
        private readonly int _maxWidth;
        private readonly int _maxHeight;
        private readonly GridPosition _obstacle;

        public Grid(int maxWidth, int maxHeight, GridPosition obstacle = null)
        {
            this._maxWidth = maxWidth;
            this._maxHeight = maxHeight;

            if (obstacle != null)
                this._obstacle = obstacle;
        }

        public GridPosition MoveNorth(GridPosition position) =>
            CheckForObstacles(WrapAroundIfNecessary(position.X, position.Y + 1));

        public GridPosition MoveEast(GridPosition position) =>
            CheckForObstacles(WrapAroundIfNecessary(position.X + 1, position.Y));

        public GridPosition MoveSouth(GridPosition position) =>
            CheckForObstacles(WrapAroundIfNecessary(position.X, position.Y - 1));

        public GridPosition MoveWest(GridPosition position) =>
            CheckForObstacles(WrapAroundIfNecessary(position.X - 1, position.Y));

        private GridPosition CheckForObstacles(GridPosition newPosition)
        {
            if (newPosition.Equals(_obstacle))
                throw new EncounteredObstacleException();
                    
            return newPosition;
        }

        private GridPosition WrapAroundIfNecessary(int x, int y)
        {
            if (x == _maxWidth)
                x = 0;
            if (x == -1)
                x = _maxWidth - 1;
            if (y == _maxHeight)
                y = 0;
            if (y == -1)
                y = _maxHeight - 1;

            return new GridPosition(x, y);
        }
    }
}