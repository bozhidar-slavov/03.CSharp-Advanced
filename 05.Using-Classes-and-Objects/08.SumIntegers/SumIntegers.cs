using System;

class SumIntegers
{
    static int CalculateSumOfIntegers(string[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += Convert.ToInt32(sequence[i]);
        }

        return sum;
    }

    static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        Console.WriteLine(CalculateSumOfIntegers(sequence));
    }
}