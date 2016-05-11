namespace MarsRoverKata.Src
{
    internal class South : IDirection
    {
        public IDirection RotateLeft() => new East();

        public IDirection RotateRight() => new West();

        public char ToOutputFormat() => 'S';
    }
}