using System;

class BinaryToHexadecimal
{
    static string BinaryToHexadecimalConvert(string binaryNumber)
    {
        for (int i = 0; i < binaryNumber.Length % 4; i++)
        {
            binaryNumber = "0" + binaryNumber;
        }
        
        string hexadecimal = string.Empty;
        for (int i = 0; i < binaryNumber.Length; i+=4)
        {
            switch (binaryNumber.Substring(i, 4))
            {
                case "0000": hexadecimal += "0"; break;
                case "0001": hexadecimal += "1"; break;
                case "0010": hexadecimal += "2"; break;
                case "0011": hexadecimal += "3"; break;
                case "0100": hexadecimal += "4"; break;
                case "0101": hexadecimal += "5"; break;
                case "0110": hexadecimal += "6"; break;
                case "0111": hexadecimal += "7"; break;
                case "1000": hexadecimal += "8"; break;
                case "1001": hexadecimal += "9"; break;
                case "1010": hexadecimal += "A"; break;
                case "1011": hexadecimal += "B"; break;
                case "1100": hexadecimal += "C"; break;
                case "1101": hexadecimal += "D"; break;
                case "1110": hexadecimal += "E"; break;
                case "1111": hexadecimal += "F"; break;
            }
        }

        return hexadecimal;
    }

    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToHexadecimalConvert(binaryNumber));
    }
}