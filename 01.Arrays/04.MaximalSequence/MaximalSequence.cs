using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int currentSequence = 1;
        int bestSequence = 1;
        int bestNumber = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentSequence++;
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestNumber = numbers[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
        }

        Console.WriteLine(bestSequence);
    }
}