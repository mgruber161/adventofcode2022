namespace aoc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aoc3");

            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc3\aoc3.txt");
            char? commonItem = null;
            int sum = 0;
            foreach (var item in input)
            {
                for (int i = 0; i < item.Length / 2; i++)
                {
                    for (int j = item.Length / 2; j < item.Length; j++)
                    {
                        if (item[i] == item[j])
                            commonItem = item[i];
                    }
                }
                sum += (int)commonItem > 96 ? (int)commonItem - 96 : (int)commonItem - 38;
            }
            Console.WriteLine(sum);
        }
    }
}