using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            bool isIncreasing = true;
            for (int j = 0; j < numbers.Length - 2; j++)
            {
                if (numbers.Length == 2)
                {
                    break;
                }
                else
                {
                    if (Math.Abs(numbers[j + 1] - numbers[j + 2]) - Math.Abs(numbers[j] - numbers[j + 1]) > 1 ||
                        Math.Abs(numbers[j] - numbers[j + 1]) > Math.Abs(numbers[j + 1] - numbers[j + 2]))
                    {
                        isIncreasing = false;
                    }
                }
            }

            Console.WriteLine(isIncreasing);
        }
    }
}