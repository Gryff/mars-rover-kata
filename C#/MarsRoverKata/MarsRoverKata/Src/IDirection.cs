namespace MarsRoverKata.Src
{
    interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        GridPosition MoveForwardFrom(GridPosition position, Grid grid);
        char ToOutputFormat();
    }
}
