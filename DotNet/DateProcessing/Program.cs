// ask the user for two dates
Console.WriteLine("Please enter the first date:");
string date1Input = Console.ReadLine();

Console.WriteLine("Please enter the second date:");
string date2Input = Console.ReadLine();

// convert the input strings to DateTimes
DateTime firstDate = DateTime.Parse(date1Input);
DateTime secondDate = DateTime.Parse(date2Input);

Console.WriteLine(firstDate);
Console.WriteLine(secondDate);
