namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft()
        {
            return new South();
        }
    }
}
