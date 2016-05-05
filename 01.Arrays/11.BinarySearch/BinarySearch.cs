using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int searchingNumber = int.Parse(Console.ReadLine());

        Array.Sort(sequence);

        int iMin = 0;
        int iMax = sequence.Length - 1;
        int iMid = sequence.Length / 2;
        bool foundNumber = false;

        while (iMin <= iMax)
        {
            iMid = (iMin + iMax) / 2;
            if (sequence[iMid] == searchingNumber)
            {
                foundNumber = true;
                Console.WriteLine(iMid);
                break;
            }
            else if (sequence[iMid] < searchingNumber)
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }
        }

        if (!foundNumber)
        {
            Console.WriteLine(-1);
        }
    }
}