using System;
using System.Collections.Generic;

class SubsetKWithSumS
{
    static void Main()
    {
        int[] sequence = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;
        int k = 4;

        int maxSubsets = (int)Math.Pow(2, sequence.Length) - 1;
        int counter = 0;
        List<int> subset = new List<int>();

        for (int i = 1; i <= maxSubsets; i++)
        {
            subset.Clear();
            long currentSum = 0;
            int currentK = 0;

            for (int j = 0; j <= sequence.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += sequence[j];
                    subset.Add(sequence[j]);
                    currentK++;
                }
            }

            if (currentSum == sum && currentK == k)
            {
                counter++;
                Console.WriteLine($"Subset sum {sum}: {string.Join(", ", subset)}");
            }
        }

        Console.WriteLine("Total subsets: " + counter);
    }
}