using System;
using System.Text;

class EncodeDecode
{
    static string EncodingDecoding(string input, string cipher)
    {
        var output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            output.Append((char)(input[i] ^ cipher[(i % cipher.Length)]));
        }

        return output.ToString();
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter cipher: ");
        string cipher = Console.ReadLine();

        string encoded = EncodingDecoding(input, cipher);
        string decoded = EncodingDecoding(encoded, cipher);
        Console.WriteLine("Encoded: " + encoded);
        Console.WriteLine("Decoded: " + decoded);
    }
}