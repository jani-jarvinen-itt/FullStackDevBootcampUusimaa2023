public class HighScoreHandler
{
    const string HighScoreFilename = @"C:\Bootcamp\Uusimaa\Code\DotNet\NumberGuessingGame\HighScores.csv";

    public void RecordPlayerScore(int numberOfGuesses)
    {
        Console.WriteLine("Please enter your name for the high score table:");
        string playerName = Console.ReadLine();

        string csvLine = numberOfGuesses + ";" + playerName + System.Environment.NewLine;
        File.AppendAllText(HighScoreFilename, csvLine);
    }

    public void DisplayHighScoreList()
    {
        string[] lines = File.ReadAllLines(HighScoreFilename);
        Array.Sort(lines);

        int counter = 1;
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int numberOfGuess = int.Parse(parts[0]);
            string playerName = parts[1];

            /*
            int numberOfGuess2 = int.Parse(line.Split(';')[0]);
            string playerName2 = line[2..]; // line.Substring(2);
            */

            Console.WriteLine($"Position {counter}: {playerName}, number of guesses: {numberOfGuess}.");
            counter++;
        }
    }
}
