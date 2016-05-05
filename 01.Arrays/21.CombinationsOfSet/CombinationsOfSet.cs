using System;

class CombinationsOfSet
{
    static void GenerateCombinations(int[] array, int index, int start, int end)
    {
        if (index >= array.Length)
        {
            Console.WriteLine("{" + string.Join(", ", array) + "}");
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                array[index] = i;
                GenerateCombinations(array, index + 1, i + 1, end);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        
        int start = 1;

        int[] array = new int[k];
        GenerateCombinations(array, 0, start, end);
    }
}