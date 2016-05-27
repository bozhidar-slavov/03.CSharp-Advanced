using System;

class Palindromes
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        string palindromes = string.Empty;
        foreach (var word in words)
        {
            char[] checkPalindrome = word.ToCharArray();
            Array.Reverse(checkPalindrome);
            string temp = new string(checkPalindrome);
            if (temp == word)
            {
                palindromes += word;
                palindromes += " ";
            }
        }

        if (palindromes.Length == 0)
        {
            Console.WriteLine("Palindromes not found!");
        }
        else
        {
            Console.WriteLine("Palindromes: " + palindromes);
        }
    }
}