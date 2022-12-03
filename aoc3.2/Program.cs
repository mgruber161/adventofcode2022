namespace aoc3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aoc3");

            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc3\aoc3.txt");
            char? commonItem = null;
            int sum = 0;
            for(int i = 0; i < input.Length-2; i+=3)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    for (int k = 0; k < input[i+1].Length; k++)
                    {
                        for (int l = 0; l < input[i + 2].Length; l++)
                        {
                            if (input[i][j] == input[i + 1][k] && input[i][j] == input[i + 2][l])
                                commonItem = input[i][j];
                        }
                    }
                }
                sum += (int)commonItem > 96 ? (int)commonItem - 96 : (int)commonItem - 38;
            }
            Console.WriteLine(sum);
        }
    }
}