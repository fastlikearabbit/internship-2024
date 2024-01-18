namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Missing string argument.");
                return;
            }

            PrintSubstrings(args[0]);
        }

        static void PrintSubstrings(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[j - 1] == word[j])
                    {
                        break;
                    }
                    Console.WriteLine(word.Substring(i, j - i + 1));
                }
            }
        }
    }
}