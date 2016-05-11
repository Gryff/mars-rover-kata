namespace MarsRoverKata.Src
{
    internal class East : IDirection
    {
        public IDirection RotateLeft() => new North();

        public IDirection RotateRight() => new South();

        public char ToOutputFormat() => 'E';
    }
}