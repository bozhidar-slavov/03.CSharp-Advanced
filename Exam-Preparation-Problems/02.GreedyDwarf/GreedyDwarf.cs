using System;
using System.Linq;

class GreedyDwarf
{
    static void Main()
    {
        int[] valley = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int n = int.Parse(Console.ReadLine());
        long bestCoins = long.MinValue;
        for (int i = 0; i < n; i++)
        {
            int[] pattern = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            bool[] isVisited = new bool[valley.Length];
            long coins = 0;
            int index = 0;
            int patternIndex = 0;
            while (true)
            {
                if ((index < 0 || index >= valley.Length) || isVisited[index] == true)
                {
                    break;
                }

                coins += valley[index];
                isVisited[index] = true;
                index += pattern[patternIndex % pattern.Length];
                patternIndex++;
            }

            if (coins > bestCoins)
            {
                bestCoins = coins;
            }
        }

        Console.WriteLine(bestCoins);
    }
}