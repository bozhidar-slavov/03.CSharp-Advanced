using System;

class SubStringInText
{
    static int SubstringAppearance(string text, string pattern)
    {
        int counter = 0;
        for (int i = 0; i < text.Length - pattern.Length + 1; i++)
        {
            if (text.Substring(i, pattern.Length) == pattern)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        Console.WriteLine(SubstringAppearance(text, pattern));
    }
}