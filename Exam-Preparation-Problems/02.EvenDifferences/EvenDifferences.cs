using System;
using System.Collections.Generic;

class EvenDifferences
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(' ');

        var list = new List<long>();
        foreach (var number in array)
        {
            list.Add(Convert.ToInt32(number));
        }

        long absSum = 0;
        var absSumList = new List<long>();
        for (int i = 1; i < list.Count;)
        {
            absSum += Math.Abs(list[i - 1] - list[i]);
            absSumList.Add(absSum);
            if (absSum % 2 == 0)
            {
                i += 2;
            }
            else
            {
                i++;
            }
            if (i > list.Count)
            {
                break;
            }

            absSum = 0;
        }

        long result = 0;
        foreach (var number in absSumList)
        {
            if (number % 2 == 0)
            {
                result += number;
            }
        }

        Console.WriteLine(result);
    }
}