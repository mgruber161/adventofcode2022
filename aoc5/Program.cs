using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace aoc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc5\aoc5.txt");
            var stacks = ReadStack(input.Take(8).ToArray());
            var result = String.Empty;
            input = input.Skip(10).ToArray();
            foreach (var item in input)
            {
                int[] numbers = Regex.Split(item, @"\D+").Skip(1).ToArray().Select(int.Parse).ToArray();
                for(int i= 0; i < numbers[0]; i++) {
                    var tmp = stacks[numbers[1]-1].Pop();
                    stacks[numbers[2] - 1].Push(tmp);
                }
            }
            foreach (var stack in stacks)
                result += stack.Peek()!.ToString();
            Console.WriteLine(result);
        }

        public static List<Stack> ReadStack(string[] input)
        {
            List<Stack> stacks = new List<Stack>();
            for (int j = 1; j < 34; j += 4)
            {
                stacks.Add(new Stack());
                for (int i = 7; i > -1; i--)
                    if (input[i][j] != ' ')
                        stacks[j / 4].Push(input[i][j]);
            }
            return stacks;
        }
    }
}