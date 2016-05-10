using System;
using System.Linq;

class AppearanceCount
{
    static int CountAppearance(int[] numbers, int searchingNumber)
    {
        int counter = 0;
        foreach (var number in numbers)
        {
            if (number == searchingNumber)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int searchingNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(CountAppearance(numbers, searchingNumber));
    }
}