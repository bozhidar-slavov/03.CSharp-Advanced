using System;
using System.Collections.Generic;
using System.Text;

class CalculationProblem
{
    private static int j;

    static long PowerOfTwentyThree(int power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 23;
        }

        return result;
    }

    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');

        var alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w" };
        int numeralSystem = 23;
        long decimalNumber = 0;
        long output = 0;

        foreach (var word in words)
        {
            for (int i = 0, position = word.Length - 1; i < word.Length; i++, position--)
            {
                var digitIn23th = word.Substring(i, 1);
                var decimalValue = alphabet.IndexOf(digitIn23th);
                decimalNumber += decimalValue * PowerOfTwentyThree(position);
            }

            output += decimalNumber;
            decimalNumber = 0;
        }

        var result = new StringBuilder();
        long numberInDecimal = output;

        if (numberInDecimal == 0)
        {
            Console.WriteLine("0 = 0");
        }
        else
        {
            while (numberInDecimal > 0)
            {
                int digitIn23th = (int)numberInDecimal % numeralSystem;
                result.Insert(0, alphabet[digitIn23th]);
                numberInDecimal /= numeralSystem;
            }

            Console.WriteLine(result + " = " + output);
        }
    }
}