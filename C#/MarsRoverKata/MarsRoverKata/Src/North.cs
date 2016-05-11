namespace MarsRoverKata.Src
{
    class North : IDirection
    {
        public IDirection RotateLeft()
        {
            return new West();
        }

        public IDirection RotateRight()
        {
            return new East();
        }
    }
}
