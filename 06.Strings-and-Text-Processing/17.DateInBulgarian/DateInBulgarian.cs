using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter date and time in format (d.MM.yyyy HH:mm:ss): ");
        string input = Console.ReadLine();

        var culture = new CultureInfo("bg-BG");
        var dateAndTime = DateTime.ParseExact(input, "d.MM.yyyy HH:mm:ss", culture).AddHours(6).AddMinutes(30);

        Console.WriteLine("Time after 6h and 30min: {0}", dateAndTime);
        Console.WriteLine("Day of week: {0}", culture.DateTimeFormat.GetDayName(dateAndTime.DayOfWeek));
    }
}