namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft()
        {
            return new South();
        }

        public IDirection RotateRight()
        {
            return new North();
        }
    }
}
