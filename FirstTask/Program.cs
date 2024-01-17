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
            var mapping = new Dictionary<char, int>()
            {
                { 'A', 1 },
                { 'B', 2 },
                { 'C', 3 },
                { 'D', 4 },
                { 'E', 5 },
                { 'F', 6 },
                { 'G', 7 },
                { 'H', 8 },
            };

            int column = mapping[Char.ToUpper(position[0])];
            int row = int.Parse(position[1].ToString());

            if ((row + column) % 2 == 1)
            {
                return Color.White;
            }

            return Color.Black;
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