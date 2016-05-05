using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            int iMin = i;
            for (int j = i + 1; j < sequence.Length; j++)
            {
                if (sequence[j] < sequence[iMin])
                {
                    iMin = j;
                }
            }

            if (iMin != i)
            {
                sequence[i] = sequence[i] + sequence[iMin];
                sequence[iMin] = sequence[i] - sequence[iMin];
                sequence[i] = sequence[i] - sequence[iMin];
            }
        }

        foreach (var number in sequence)
        {
            Console.WriteLine(number);
        }
    }
}