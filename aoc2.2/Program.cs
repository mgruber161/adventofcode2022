namespace aoc2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aoc2");
            var input = File.ReadAllLines(@"C:\Users\grube\Source\repos\AOC\aoc2\aoc2.txt");
            GameChoices opponentChoice = GameChoices.Rock;
            GameChoices playerChoice = GameChoices.Rock;
            GameResults gameResult = GameResults.Draw;
            List<int> results = new List<int>();
            foreach (var item in input)
            {
                switch (item[0])
                {
                    case 'A':
                        opponentChoice = GameChoices.Rock;
                        break;
                    case 'B':
                        opponentChoice = GameChoices.Paper;
                        break;
                    case 'C':
                        opponentChoice = GameChoices.Scissors;
                        break;
                }
                switch (item[2])
                {
                    case 'X':
                        gameResult = GameResults.Loss;
                        break;
                    case 'Y':
                        gameResult = GameResults.Draw;
                        break;
                    case 'Z':
                        gameResult = GameResults.Win;
                        break;
                }
                if (gameResult == GameResults.Draw)
                    playerChoice = opponentChoice;
                else
                {
                    if (gameResult == GameResults.Loss)
                    {
                        if (opponentChoice == GameChoices.Paper)
                            playerChoice = GameChoices.Rock;
                        else if (opponentChoice == GameChoices.Scissors)
                            playerChoice = GameChoices.Paper;
                        else if (opponentChoice == GameChoices.Rock)
                            playerChoice = GameChoices.Scissors;
                    }
                    else if (gameResult == GameResults.Win)
                    {
                        if (opponentChoice == GameChoices.Rock)
                            playerChoice = GameChoices.Paper;
                        else if (opponentChoice == GameChoices.Scissors)
                            playerChoice = GameChoices.Rock;
                        else if (opponentChoice == GameChoices.Paper)
                            playerChoice = GameChoices.Scissors;
                    }
                }

                results.Add((int)gameResult + (int)playerChoice);
            }
            Console.WriteLine(results.Sum());
        }


    }

    public enum GameChoices
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    public enum GameResults
    {
        Loss = 0,
        Draw = 3,
        Win = 6
    }
}