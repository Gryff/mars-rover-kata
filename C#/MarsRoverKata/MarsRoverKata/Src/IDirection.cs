namespace MarsRoverKata.Src
{
    internal interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        GridPosition MoveForwardFrom(GridPosition position, Grid grid);
    }
}
