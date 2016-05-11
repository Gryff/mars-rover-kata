namespace MarsRoverKata.Src
{
    class West : IDirection
    {
        public IDirection RotateLeft() => new South();

        public IDirection RotateRight() => new North();
        
        public char ToOutputFormat() => 'W';
    }
}
