using System;
using System.Linq;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] words = text.Split(' ', '.', ',');

        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        for (int i = 0; i < words.Length; i++)
        {
            if (forbiddenWords.Contains(words[i]))
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
        }

        Console.WriteLine(text);
    }
}