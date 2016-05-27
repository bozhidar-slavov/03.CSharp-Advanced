using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        foreach (var symbol in input)
        {
            Console.Write("\\u{0:X4}", Convert.ToInt32(symbol));
        }

        Console.WriteLine();
    }
}