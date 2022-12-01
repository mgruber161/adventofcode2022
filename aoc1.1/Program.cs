namespace aoc1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aoc1.1");
            var input = File.ReadAllLines("aoc_1.txt");
            List<int> calories = new List<int>();
            Elf currElf = new Elf();
            int tmp;
            int highest = 0;
            foreach (var item in input)
            {
                if(item == "")
                {
                    calories.Add(currElf.Calories);
                    currElf = new Elf();
                }
                else if(Int32.TryParse(item, out tmp))
                {
                    currElf.Calories += tmp;
                }
            }
            calories.Sort();
            calories.Reverse();
            highest= calories[0] + calories[1] + calories[2];
            Console.WriteLine(highest);
            Console.ReadKey();
        }
    }

    public class Elf
    {
        public int Calories { get; set; } = 0;
    }
}