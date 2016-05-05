using System;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] longestIncreasingSequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            longestIncreasingSequence[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i])
                {
                    longestIncreasingSequence[i] = Math.Max(longestIncreasingSequence[i], longestIncreasingSequence[j] + 1);
                }
            }
        }

        Console.WriteLine(n - longestIncreasingSequence.Max());
    }
}