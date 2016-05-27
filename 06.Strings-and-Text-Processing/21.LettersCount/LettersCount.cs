using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        var dictionary = new Dictionary<char, int>();

        foreach (var symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                if (!dictionary.ContainsKey(symbol))
                {
                    dictionary.Add(symbol, 1);
                }
                else
                {
                    dictionary[symbol]++;
                }
            }
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
        }
    }
}