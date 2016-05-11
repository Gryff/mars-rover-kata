namespace MarsRoverKata.Src
{
    internal class South : IDirection
    {
        public IDirection RotateLeft()
        {
            return new East();
        }

        public IDirection RotateRight()
        {
            return new West();
        }
    }
}