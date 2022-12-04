using System.Linq;

namespace aoc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc4\aoc4.txt");
            int lowerBound, upperBound, count = 0;
            var assignments = new List<int>();
            var groupAssignments = new List<int[]>();
            foreach (var item in input)
            {
                var pairs = item.Split(',');
                foreach (var pair in pairs)
                {
                    var limits = pair.Split('-');
                    Int32.TryParse(limits[0], out lowerBound);
                    Int32.TryParse(limits[1], out upperBound);
                    for (int i = lowerBound; i <= upperBound; i++)
                        assignments.Add(i);
                    groupAssignments.Add(assignments.ToArray());
                    assignments.Clear();
                }
                if (groupAssignments[0].Intersect(groupAssignments[1]).ToArray().SequenceEqual(groupAssignments[1])
                    || groupAssignments[0].Intersect(groupAssignments[1]).ToArray().SequenceEqual(groupAssignments[0]))
                    count++;
                groupAssignments.Clear();
            }
            Console.WriteLine(count);
        }
    }
}