using System;
using System.Collections.Generic;
using System.Text;

class KaspichanNumbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        var alphabet = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            alphabet.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                alphabet.Add(i.ToString() + j);
            }
        }

        var result = new StringBuilder();
        ulong numeralSystem = 256;
        if (input == 0)
        {
            Console.WriteLine("A");
        }
        while (input > 0)
        {
            ulong digitIn256th = input % numeralSystem;
            result.Insert(0, alphabet[(int)digitIn256th]);
            input /= numeralSystem;
        }

        Console.WriteLine(result);
    }
}