using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    public static int[] Addition(int[] firstPoly, int[] secondPoly)
    {
        if (firstPoly.Length < secondPoly.Length)
        {
            return Addition(secondPoly, firstPoly);
        }

        int[] sumOfPoly = new int[firstPoly.Length];

        for (int i = 0; i < secondPoly.Length; i++)
        {
            sumOfPoly[i] = firstPoly[i] + secondPoly[i];
        }

        for (int i = secondPoly.Length; i < firstPoly.Length; i++)
        {
            sumOfPoly[i] = firstPoly[i];
        }

        return sumOfPoly;
    }

    static void Main()
    {
        Console.ReadLine();
        int[] firstCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        int[] sum = Addition(firstCoef, secondCoef);

        var list = new List<int>();
        for (int i = 0; i < sum.Length; i++)
        {
            list.Add(sum[i]);
        }

        Console.WriteLine(string.Join(" ", list));
    }
}