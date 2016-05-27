using System;

class ReverseSentence
{
    static string SentenceReverseWordByWord(string sentence)
    {
        string output = sentence[sentence.Length - 1].ToString();
        sentence = sentence.Insert(0, " ");
        int length = 0;
        int startIndex = 0;
        for (int i = 0; i < sentence.Length - 1; i++)
        {
            length++;
            if ((sentence[i + 1] == ' ' && sentence[i] != ',') || sentence[i + 1] == ',' || i == sentence.Length - 2)
            {
                string value = sentence.Substring(startIndex, length);
                startIndex = i + 1;
                length = 0;
                output = output.Insert(0, value);
            }
        }

        return output.Trim();   
    }

    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";

        Console.WriteLine(SentenceReverseWordByWord(sentence));
    }
}