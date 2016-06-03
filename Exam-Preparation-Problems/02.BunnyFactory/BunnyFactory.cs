using System;
using System.Collections.Generic;
using System.Numerics;

class BunnyFactory
{
    static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger sum = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            sum += list[i];
        }

        return sum;
    }

    static BigInteger ProductListValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger product = 1;
        for (int i = startIndex; i <= endIndex; i++)
        {
            product *= list[i];
        }

        return product;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        var list = new List<int>();
        while (input != "END")
        {
            list.Add(Convert.ToInt32(input));
            input = Console.ReadLine();
        }

        for (int stepNumber = 1; ; stepNumber++)
        {
            if (list.Count < stepNumber)
            {
                break;
            }

            var cagesCount = (int)SumListValuesInRange(list, 0, stepNumber - 1);
            if (list.Count < stepNumber + cagesCount)
            {
                break;
            }

            var sum = SumListValuesInRange(list, stepNumber, cagesCount + stepNumber - 1);
            var product = ProductListValuesInRange(list, stepNumber, cagesCount + stepNumber - 1);
            string result = sum.ToString() + product.ToString();

            for (int i = cagesCount + stepNumber; i < list.Count; i++)
            {
                result += list[i];
            }

            list.Clear();
            foreach (var symbol in result)
            {
                if (symbol != '1' && symbol != '0')
                {
                    list.Add(symbol - '0');
                }
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}