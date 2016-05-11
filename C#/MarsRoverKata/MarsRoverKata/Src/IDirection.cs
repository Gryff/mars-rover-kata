namespace MarsRoverKata.Src
{
    interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        GridPosition MoveForwardFrom(GridPosition position, GridSize gridSize);
        char ToOutputFormat();
    }
}
