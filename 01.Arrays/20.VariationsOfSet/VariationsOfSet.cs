using System;

class VariationsOfSet
{
    static void GenerateVariations(int[] array, int index, int numbers)
    {
        if (index == array.Length)
        {
            Console.WriteLine("{" + string.Join(", ", array) + "}");
        }
        else
        {
            for (int i = 1; i <= numbers; i++)
            {
                array[index] = i;
                GenerateVariations(array, index + 1, numbers);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[k];

        GenerateVariations(array, 0, n);
    }
}