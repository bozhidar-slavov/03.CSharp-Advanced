using System;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        string[] splitted = text.Split('.');
        char[] symbols = text.Where(x => !char.IsLetter(x)).Distinct().ToArray();

        var result = new StringBuilder();
        foreach (var sentence in splitted)
        {
            string[] words = sentence.Split(symbols);

            for (int i = 0; i < words.Length; i++)
            {
                if (pattern == words[i])
                {
                    result.Append(sentence.Trim());
                    result.Append(". ");
                    break;
                }
            }
        }

        Console.WriteLine(result);
    }
}