using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "Ronaldinho Gaucho was born 21.03.1980.";
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], @"\b\d{1,2}\.\d{1,2}.\d{4}"))
            {
                if (Regex.IsMatch(words[i], @"..$"))
                {
                    words[i] = words[i].Remove(words[i].Length - 1);
                }

                DateTime date = DateTime.ParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToShortDateString().ToString(new CultureInfo("en-CA")));
            }
        }
    }
}