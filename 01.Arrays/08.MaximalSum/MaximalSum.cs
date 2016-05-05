using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = sequence[0];
        int currentSum = sequence[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;
        
        for (int i = 1; i < sequence.Length; i++)
        {
            currentSum += sequence[i];
            if (currentSum < sequence[i])
            {
                currentSum = sequence[i];
                startTemp = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.WriteLine(maxSum);
    }
}