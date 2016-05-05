using System;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter sequence of numbers: ");
        int[] sequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());

        int currentSum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = i; j < sequence.Length; j++)
            {
                currentSum += sequence[j];
                if (currentSum == sum)
                {
                    Console.Write("Number(s) with sum {0}: ", sum);
                    for (int print = i; print <= j;  print++)
                    {
                        if (print < j)
                        {
                            Console.Write("{0}, ", sequence[print]);
                        }
                        else
                        {
                            Console.WriteLine(sequence[print]);
                        }
                    }
                }

                else
                {
                    continue;
                }
            }

            currentSum = 0;
        }
    }
}