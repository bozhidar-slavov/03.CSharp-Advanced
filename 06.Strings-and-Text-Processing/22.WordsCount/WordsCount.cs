using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter words: ");
        string text = Console.ReadLine();
        MatchCollection words = Regex.Matches(text, @"\b\w+\b");

        var dictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!dictionary.ContainsKey(word.ToString()))
            {
                dictionary.Add(word.ToString(), 1);
            }
            else
            {
                dictionary[word.ToString()]++;
            }
        }
        
        foreach (var word in dictionary)
        {
            Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
        }
    }
}