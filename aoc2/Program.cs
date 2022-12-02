namespace aoc2
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
            int sum = 0;
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
                        playerChoice = GameChoices.Rock;
                        break;
                    case 'Y':
                        playerChoice = GameChoices.Paper;
                        break;
                    case 'Z':
                        playerChoice = GameChoices.Scissors;
                        break;
                }
                if (opponentChoice == playerChoice)
                    gameResult = GameResults.Draw;
                else
                {
                    if (opponentChoice == GameChoices.Rock)
                    {
                        if (playerChoice == GameChoices.Paper)
                            gameResult = GameResults.Win;
                        else if (playerChoice == GameChoices.Scissors)
                            gameResult = GameResults.Loss;
                    }
                    else if(opponentChoice == GameChoices.Paper)
                    {
                        if (playerChoice == GameChoices.Rock)
                            gameResult = GameResults.Loss;
                        else if (playerChoice == GameChoices.Scissors)
                            gameResult = GameResults.Win;
                    }
                    else if(opponentChoice == GameChoices.Scissors)
                    {
                        if (playerChoice == GameChoices.Rock)
                            gameResult = GameResults.Win;
                        else if (playerChoice == GameChoices.Paper)
                            gameResult = GameResults.Loss;
                    }
                }
                results.Add((int)gameResult + (int)playerChoice);
                sum += (int)gameResult + (int)playerChoice;
            }
            Console.WriteLine(results.Sum());
            Console.WriteLine(sum);
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