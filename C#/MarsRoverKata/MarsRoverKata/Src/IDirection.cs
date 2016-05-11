namespace MarsRoverKata.Src
{
    interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        char ToOutputFormat();
        GridPosition MoveForwardFrom(GridPosition position);
    }
}
