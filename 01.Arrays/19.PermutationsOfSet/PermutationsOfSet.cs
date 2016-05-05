using System;

class PermutationsOfSet
{
    static void Permutation(int[] array, int index, int length)
    {
        if (index == length)
        {
            Console.WriteLine("{" + string.Join(", ", array) + "}");
        }

        for (int i = index; i < array.Length; i++)
        {
            Swap(array, i, index);
            Permutation(array, index + 1, length);
            Swap(array, i, index);

        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Permutation(array, 0, n);
    }
}