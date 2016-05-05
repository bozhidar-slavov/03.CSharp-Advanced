using System;
using System.Collections.Generic;

class QuickSort
{
    static List<int> QuickSortAlgorithm(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }

        int pivot = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivot];
        unsortedList.RemoveAt(pivot);
        List<int> smallerThanPivot = new List<int>();
        List<int> biggerThanPivot = new List<int>();
        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                smallerThanPivot.Add(element);
            }
            else
            {
                biggerThanPivot.Add(element);
            }
        }

        List<int> result = new List<int>();
        result.AddRange(QuickSortAlgorithm(smallerThanPivot));
        result.Add(pivotValue);
        result.AddRange(QuickSortAlgorithm(biggerThanPivot));
        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        List<int> sortedArray = QuickSortAlgorithm(array);

        foreach (var number in sortedArray)
        {
            Console.WriteLine(number);
        }
    }
}