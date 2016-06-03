using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static long Power(int power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 168;
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        var alphabet = new List<string>();
        char upperCase = 'A';
        for (int i = 1; i <= 26; i++)
        {
            alphabet.Add(upperCase.ToString());
            upperCase++;
        }

        char lowerCase = 'a';
        upperCase = 'A';
        for (int i = 27; i <= 168; i++)
        {
            alphabet.Add(string.Format("{0}{1}", lowerCase, upperCase));
            upperCase++;
            if (i % 26 == 0)
            {
                lowerCase++;
                upperCase = 'A';
            }
        }

        var inputAlphabet = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLower(input[i]))
            {
                inputAlphabet.Add(string.Format("{0}{1}", input[i], input[i + 1]));
                i++;
            }
            else
            {
                inputAlphabet.Add(input[i].ToString());
            }
        }

        long output = 0;
        for (int i = 0, j = inputAlphabet.Count - 1; i < inputAlphabet.Count; i++, j--)
        {
            output += alphabet.IndexOf(inputAlphabet[i]) * Power(j);
        }

        Console.WriteLine(output);
    }
}