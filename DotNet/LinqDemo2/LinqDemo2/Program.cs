int[] numbers = { 5, 25, 37, 12, 48, 41, 33, 29 };

// classical solution: sort and display numbers above 20
Array.Sort(numbers);
foreach (int number in numbers)
{
    if (number > 20)
    {
        Console.WriteLine(number);
    }
}

Console.WriteLine("------------");

// LINQ query for the above logic
var results = from n in numbers
              where n > 20
              orderby n
              select n;
foreach (int number in results)
{
    Console.WriteLine(number);
}
