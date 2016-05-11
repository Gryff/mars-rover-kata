namespace MarsRoverKata.Src
{
    class North : IDirection
    {
        public IDirection RotateLeft()
        {
            return new West();
        }
    }
}
