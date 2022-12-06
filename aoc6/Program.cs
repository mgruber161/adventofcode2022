namespace aoc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = File.ReadAllText(@"C:\Users\grube\Source\repos\AOC\aoc6\aoc6.txt");
            for (int i = 0; i < t.Length; i++)
            {
                if (new char[] { t[i], t[i+1], t[i+2], t[i+3] }.Distinct().Count() == 4)
                {
                    Console.WriteLine(i+4);
                    break;
                }
            }
        }
    }
}