namespace MarsRoverKata.Src
{
    class Rover
    {
        public string Move(string instructions = null)
        {
            if(instructions == null)
                return "00N";

            return "01N";
        }
    }
}
