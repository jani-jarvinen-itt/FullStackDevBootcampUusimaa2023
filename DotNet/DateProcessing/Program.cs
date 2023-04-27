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
Console.WriteLine("--------");

// calculate and show the difference in the dates
TimeSpan diff = secondDate - firstDate;
Console.WriteLine(diff);

int days = diff.Days;
int hours = diff.Hours;
int min = diff.Minutes;
string diffValue = $"Date difference is {days} day(s), " +
                   $"{hours} hour(s) and {min} minute(s).";
Console.WriteLine(diffValue);

Console.WriteLine("Total difference in hours: " + diff.TotalHours);
