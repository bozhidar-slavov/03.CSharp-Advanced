using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            string word = words[i];
            int newIndex = word.Length % (n + 1);

            // words[i] = null;
            // words.Insert(newIndex, word);
            // words.Remove(null);
            words.Insert(newIndex, word);
            if (newIndex < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        int maxLenght = words.Max(word => word.Length);
        var result = new StringBuilder();
        for (int i = 0; i < maxLenght; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }

        Console.WriteLine(result.ToString());
    }
}   