/*
using System.Globalization;
CultureInfo enUs = new("en-US");
Console.WriteLine("Please enter the first date:");
string date1Input = Console.ReadLine();
DateTime firstDate = DateTime.Parse(date1Input, enUs);
Console.WriteLine(firstDate);
Console.WriteLine(firstDate.ToString(enUs));
*/

// ask the user for two dates
DateReader reader = new();
DateTime firstDate = reader.ReadADate();
DateTime secondDate = reader.ReadADate();

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
