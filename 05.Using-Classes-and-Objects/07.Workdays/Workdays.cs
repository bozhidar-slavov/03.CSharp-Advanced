using System;
using System.Globalization;
using System.Threading;

class Workdays
{
    static DateTime[] holidays =
    {
        new DateTime(2016, 3, 3),
        new DateTime(2016, 4, 13),
        new DateTime(2016, 5, 1),
        new DateTime(2016, 5, 24),
        new DateTime(2016, 9, 22),
        new DateTime(2016, 12, 24),
        new DateTime(2016, 12, 25),
        new DateTime(2016, 12, 31)
    };

    static bool IsHoliday(DateTime date)
    {
        bool result = false;
        foreach (var day in holidays)
        {
            if (date.Year == day.Year && date.Month == day.Month && date.Day == day.Day)
            {
                result = true;
            }
        }

        return result;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a date (yyyy,MM,dd): ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine());
        DateTime startDate = DateTime.Now;

        int workDays = 0;

        while (startDate.Year != targetDate.Year || startDate.Month != targetDate.Month || startDate.Day != targetDate.Day)
        {
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && IsHoliday(startDate) == false)
            {
                workDays++;
            }

            startDate = startDate.AddDays(1);
        }

        Console.WriteLine("Workdays between today and {0:MM/dd/yyyy} -> {1}", targetDate, workDays);
    }
}