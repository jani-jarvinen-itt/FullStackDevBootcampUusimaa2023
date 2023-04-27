Console.WriteLine("Exception testing, version with decimals.");

/*
int a = 100;
int b = 0;
int result = a / b; // DivideByZeroException
Console.WriteLine(result);
*/

/*
double a = 100.23;
double b = 0;
double result = a / b; // no exception!
Console.WriteLine(result);
*/

/*
decimal a = 100.23m;
decimal b = 0;
decimal result = a / b; // DivideByZeroException
Console.WriteLine(result);
*/

try
{
    Console.WriteLine("Enter number 1:");
    decimal number1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter number 2:");
    decimal number2 = decimal.Parse(Console.ReadLine());

    decimal result = number1 / number2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero. Please try again.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number entered. Please enter valid decimal numbers.");
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred! " + ex.Message);
}
