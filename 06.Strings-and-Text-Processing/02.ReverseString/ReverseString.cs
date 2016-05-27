using System;
using System.Text;

class ReverseString
{
    static string Reverse(string input)
    {
        var reversed = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(Reverse(input));
    }
}