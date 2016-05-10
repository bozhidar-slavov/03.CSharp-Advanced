using System;

class NumberCalculations
{
    static T Minimum<T>(params T[] numbers)
    {
        dynamic currentSmallest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < currentSmallest)
            {
                currentSmallest = numbers[i];
            }
        }

        return currentSmallest;
    }

    static T Maximum<T>(params T[] numbers)
    {
        dynamic currentBiggest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > currentBiggest)
            {
                currentBiggest = numbers[i];
            }
        }

        return currentBiggest;
    }

    static T Sum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    static double Average<T>(params T[] numbers)
    {
        dynamic sum = Sum(numbers);
        return (double)(sum / numbers.Length);
    }

    static T Product<T>(params T[] numbers)
    {
        dynamic product = 1;
        foreach (var num in numbers)
        {
            product *= num;
        }

        return product;
    }

    static void Main()
    {
        double[] sequence = { 13.6, 1.7, 17.3, 4.9, 15.2, 2.4, 12.1, 3.3 };

        Console.WriteLine("Min: " + Minimum(sequence));
        Console.WriteLine("Max: " + Maximum(sequence));
        Console.WriteLine("Sum: " + Sum(sequence));
        Console.WriteLine("Average: {0:F2}", Average(sequence));
        Console.WriteLine("Product: {0:F2}", Product(sequence));
    }
}