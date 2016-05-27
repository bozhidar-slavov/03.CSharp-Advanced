using System;
using System.Collections.Generic;

class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException("Exception");
        }

        return number;
    }

    static void Main()
    {
        int[] numbers = new int[10];
        int start = 0;
        int end = 100;

        try
        {
            numbers[0] = ReadNumber(start, end);
            for (int i = 1; i < numbers.Length; i++)
            {
                start = numbers[i - 1];
                numbers[i] = ReadNumber(start, end);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
            return;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Exception");
            return;
        }

        Console.Write("1 < ");
        Console.Write(string.Join(" < ", numbers));
        Console.WriteLine(" < 100");
    }
}