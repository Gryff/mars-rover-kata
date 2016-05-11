namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft()
        {
            return new North();
        }
    }
}