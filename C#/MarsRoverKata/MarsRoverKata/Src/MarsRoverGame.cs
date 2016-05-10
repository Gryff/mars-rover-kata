namespace MarsRoverKata
{
    class MarsRoverGame
    {
        private Grid _grid;
        private Rover _rover;
        
        public void GenerateGrid(int x, int y)
        {
            _grid = new Grid(x, y);
        }

        public string GetGridSize()
        {
            return _grid.ToOutputFormat();
        }

        public void SetRoverLocation(int x, int y, char direction)
        {
            _rover = new Rover(x, y, direction);
        }

        public string GetRoverLocation()
        {
            return _rover.GetLocation();
        }

        public void MoveRover(string moves)
        {
            foreach (var move in moves)
            {
                if(move == 'M')
                    _rover.MoveForward();

                if(move == 'L')
                    _rover.RotateLeft();

                if(move == 'R')
                    _rover.RotateRight();
            }
        }
    }
}
