﻿using System.Linq;

namespace aoc4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc4\aoc4.txt");
            int lowerBound = 0;
            int upperBound = 0;
            var assignments = new List<int>();
            var groupAssignments = new List<int[]>();
            int count = 0;
            foreach (var item in input)
            {
                var pairs = item.Split(',');
                foreach (var pair in pairs)
                {
                    var limits = pair.Split('-');
                    if (Int32.TryParse(limits[0], out lowerBound)) { }
                    if (Int32.TryParse(limits[1], out upperBound)) { }
                    for (int i = lowerBound; i <= upperBound; i++)
                        assignments.Add(i);
                    groupAssignments.Add(assignments.ToArray());
                    assignments.Clear();
                }
                if (!groupAssignments[0].Intersect(groupAssignments[1]).ToArray().SequenceEqual(new int[] { }))
                    count++;
                groupAssignments.Clear();
            }
            Console.WriteLine(count);
        }
    }
}