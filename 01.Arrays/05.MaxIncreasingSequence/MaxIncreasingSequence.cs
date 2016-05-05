using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        
        int currentSequence = 1;
        int bestSequence = 1;
        
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > sequence[i - 1])
            {
                currentSequence++;
            }
            else
            {
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                }

                currentSequence = 1;
            }
        }

        Console.WriteLine(bestSequence);
    }
}