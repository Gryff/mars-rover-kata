namespace MarsRoverKata.Src
{
    class North : IDirection
    {
        public IDirection RotateLeft() => new West();

        public IDirection RotateRight() => new East();

        public char ToOutputFormat() => 'N';
    }
}
