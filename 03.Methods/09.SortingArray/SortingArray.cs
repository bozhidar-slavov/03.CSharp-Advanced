using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.ReadLine();
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(array);

        Console.WriteLine(string.Join(" ", array));
    }
}