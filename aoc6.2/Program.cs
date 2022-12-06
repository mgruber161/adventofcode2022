namespace aoc6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = File.ReadAllText(@"C:\Users\grube\Source\repos\AOC\aoc6\aoc6.txt");
            Queue<char> arr = new Queue<char>(t.ToCharArray().Take(14));
            for (int i = 14; i < t.Length; i++)
            {
                if (arr.Distinct().Count() == 14)
                {
                    Console.WriteLine(i);
                    break;
                }
                arr.Dequeue();
                arr.Enqueue(t[i]);
            }
        }
    }
}