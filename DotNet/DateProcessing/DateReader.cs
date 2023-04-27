public class DateReader
{
    public DateTime ReadADate()
    {
        DateTime dateValue = default;
        while (true)
        {
            Console.WriteLine("Please enter a date:");
            string input = Console.ReadLine();
            try
            {
                dateValue = DateTime.Parse(input);
                break;
            }
            catch
            {
                Console.WriteLine("The date you entered was invalid. Please use the format 'd.m.yyyy hh.mm'.");
            }
        }

        return dateValue;
    }
}