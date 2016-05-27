using System;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        string[,] dictionary =
            {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR", "managed execution environment for .NET" },
                { "namespace", "hierarchical organization of classes" }
            };

        bool isFound = false;
        for (int i = 0; i < dictionary.GetLength(0); i++)
        {
            if (word == dictionary[i, 0])
            {
                Console.WriteLine(dictionary[i, 1]);
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Word not found!");
        }
    }
}