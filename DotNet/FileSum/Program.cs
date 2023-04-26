string filename = @"C:\Bootcamp\Uusimaa\Code\Numbers.txt";

IEnumerable<string> lines = File.ReadLines(filename);
int sum = 0;
foreach (string line in lines)
{
    int number = int.Parse(line);
    sum += number; // sum = sum + number;
}

Console.WriteLine("Sum of numbers in the file is: " + sum);
