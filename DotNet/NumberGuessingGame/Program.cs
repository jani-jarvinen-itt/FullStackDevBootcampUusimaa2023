Console.WriteLine("Welcome to the Number Guessing Game!");

// select random number 1-20
int correct = Random.Shared.Next(1, 21);
Console.WriteLine(correct);

// they plays has three guesses/rounds
HighScoreHandler highScore = new();
for (int round = 0; round < 3; round++)
{
    // ask the player for a guess
    Console.WriteLine("Please enter your guess between 1 and 20:");
    string guessValue = Console.ReadLine();
    int guess = int.Parse(guessValue);

    // is the guess correct?
    if (guess == correct)
    {
        Console.WriteLine("Correct! You win the game!");
        highScore.RecordPlayerScore(round + 1);
        break;
    }
    else if (guess < correct)
    {
        Console.WriteLine("The correct number is larger.");
    }
    else
    {
        Console.WriteLine("The correct number is smaller.");
    }
}

Console.WriteLine("Game ends.");

// high score display
highScore.DisplayHighScoreList();
