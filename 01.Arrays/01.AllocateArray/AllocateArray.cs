using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i * 5;
            Console.WriteLine(intArray[i]);
        }
    }
}