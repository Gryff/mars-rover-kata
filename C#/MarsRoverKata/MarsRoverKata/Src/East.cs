namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft()
        {
            return new North();
        }

        public IDirection RotateRight()
        {
            return new South();
        }
    }
}