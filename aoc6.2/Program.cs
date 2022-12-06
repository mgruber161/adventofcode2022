var t = File.ReadAllText(@"C:\Users\grube\Source\repos\AOC\aoc6\aoc6.txt");
var q = new Queue<char>(t.ToCharArray().Take(14));
for (int i = 14; i < t.Length; i++)
{
    if (q.Distinct().Count() == 14)
    {
        Console.WriteLine(i);
        break;
    }
    q.Dequeue();
    q.Enqueue(t[i]);
}