Console.WriteLine("Welcome to the Number Guessing Game!");

int correct = Random.Shared.Next(1, 21);
Console.WriteLine(correct);


Console.WriteLine("Please enter your guess between 1 and 20:");
string guessValue = Console.ReadLine();
int guess = int.Parse(guessValue);


if (guess == correct)
{
    Console.WriteLine("Correct! You win the game!");
}
else if (guess < correct)
{
    Console.WriteLine("The correct number is larger.");
}
else
{
    Console.WriteLine("The correct number is smaller.");
}





Console.WriteLine("Game ends.");
