using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date in format (d.MM.yyyy): ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date in format (d.MM.yyyy): ");
        string secondDate = Console.ReadLine();

        var startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);   

        Console.WriteLine("Distance between dates: {0} days", (endDate - startDate).TotalDays);
    }
}