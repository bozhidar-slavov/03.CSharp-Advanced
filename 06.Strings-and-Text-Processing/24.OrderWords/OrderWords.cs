using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words separated by spaces: ");
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
