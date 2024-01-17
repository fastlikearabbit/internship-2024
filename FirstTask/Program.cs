namespace FirstTask
{
    enum Color
    {
        White,
        Black
    };
    
    internal class Program
    {
        static Color GetSquareColor(string position)
        {
            return (position[0] + position[1]) % 2 == 1 ? Color.White : Color.Black;
            
        }
        static void Main(string[] args)
        {
            // should return Black
            Console.WriteLine(GetSquareColor("a1"));
            
            // should return White
            Console.WriteLine(GetSquareColor("h7"));

        }
    }
}