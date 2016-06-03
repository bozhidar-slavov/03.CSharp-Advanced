using System;
using System.Collections.Generic;
using System.Text;

class DeCatCoding
{
    static ulong PowerOfTwentyOne(int power)
    {
        ulong result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 21;
        }

        return result;
    }

    static void Main()
    {
        string[] message = Console.ReadLine().Split(' ');

        var alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u" };
        var secondAlphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        ulong numeralSystem = 26;
        ulong decimalNumber = 0;
        
        foreach (var word in message)
        {
            for (int i = 0, position = word.Length - 1; i < word.Length; i++, position--)
            {
                string digitIn21th = word.Substring(i, 1);
                ulong decimalValue = (ulong)alphabet.IndexOf(digitIn21th);
                decimalNumber += decimalValue * PowerOfTwentyOne(position);
            }

            var result = new StringBuilder();
            while (decimalNumber > 0)
            {
                ulong digitIn26th = decimalNumber % numeralSystem;
                result.Insert(0, secondAlphabet[(int)digitIn26th]);
                decimalNumber /= numeralSystem;
            }
            
            decimalNumber = 0;
            result.Append(" ");
            Console.Write(result);
        }

        Console.WriteLine();
    }
}