using System;

class ReverseNumber
{
    static string ReversedNumber(string number)
    {
        string reversed = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }

        return reversed;
    }

    static void Main()
    {
        string numberToReverse = Console.ReadLine();

        Console.WriteLine(ReversedNumber(numberToReverse));
    }
}