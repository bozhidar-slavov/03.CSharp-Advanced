using System;
using System.Linq;

class IntegerCalculations
{
    static int MinElement(int[] sequence)
    {
        int minNumber = sequence[0];
        for (int i = 0; i < sequence.Length; i++)
        {

            if (minNumber > sequence[i])
            {
                minNumber = sequence[i];
            }
        }

        return minNumber;
    }

    static int MaxElement(int[] sequence)
    {
        int maxNumber = sequence[0];

        for (int i = 0; i < sequence.Length; i++)
        {
            if (maxNumber < sequence[i])
            {
                maxNumber = sequence[i];
            }
        }

        return maxNumber;
    }

    static decimal Average(int[] sequence)
    {
        long sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        decimal average = (decimal)sum / sequence.Length;
        return average;
    }

    static long Sum(int[] sequence)
    {
        long sum = 0;
        foreach (var number in sequence)
        {
            sum += number;
        }

        return sum;
    }

    static long Product(int[] sequence)
    {
        long product = 1;
        foreach (var number in sequence)
        {
            product *= number;
        }

        return product;
    }

    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(MinElement(sequence));
        Console.WriteLine(MaxElement(sequence));
        Console.WriteLine("{0:F2}", Average(sequence));
        Console.WriteLine(Sum(sequence));
        Console.WriteLine(Product(sequence));

        // Solving the problem using extension methods:
        // Console.WriteLine("Min: " + sequence.Min());
        // Console.WriteLine("Max: " + sequence.Max());
        // Console.WriteLine("Average: {0:F2}", sequence.Average());
        // Console.WriteLine("Sum: " + sequence.Sum());
        // Console.WriteLine("Product: " + sequence.Aggregate((currentProduct, currentValue) => currentProduct * currentValue));
    }
}