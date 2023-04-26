public class HighScoreHandler
{

    public void DisplayHighScoreList()
    {
        string filename = @"C:\Bootcamp\Uusimaa\Code\DotNet\NumberGuessingGame\HighScores.csv";

        IEnumerable<string> lines = File.ReadLines(filename);
        int counter = 1;
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int numberOfGuess = int.Parse(parts[0]);
            string playerName = parts[1];

            Console.WriteLine($"Position {counter}: {playerName}, number of guesses: {numberOfGuess}.");
            counter++;
        }
    }
}
