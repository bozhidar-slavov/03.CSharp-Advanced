using System;
using System.Linq;

class LargerThanNeighbours
{
    static int NeighboursChecker(int[] numbers)
    {
        int counter = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i - 1] < numbers[i] && numbers[i + 1] < numbers[i])
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

        Console.WriteLine(NeighboursChecker(numbers));
    }
}