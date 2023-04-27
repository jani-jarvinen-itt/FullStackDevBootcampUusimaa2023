public class HighScoreHandler
{

    public void DisplayHighScoreList()
    {
        string filename = @"C:\Bootcamp\Uusimaa\Code\DotNet\NumberGuessingGame\HighScores.csv";

        string[] lines = File.ReadAllLines(filename);
        Array.Sort(lines);

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
