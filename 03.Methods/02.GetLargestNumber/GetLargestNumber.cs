using System;
using System.Linq;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        return (firstNumber > secondNumber ? firstNumber : secondNumber);
    }

    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int firstNumber = sequence[0];
        int secondNumber = sequence[1];
        int thirdNumber = sequence[2];
        
        if (GetMax(firstNumber, secondNumber) > thirdNumber)
        {
            Console.WriteLine(GetMax(firstNumber, secondNumber));
        }
        else
        {
            Console.WriteLine(thirdNumber);
        }
    }
}