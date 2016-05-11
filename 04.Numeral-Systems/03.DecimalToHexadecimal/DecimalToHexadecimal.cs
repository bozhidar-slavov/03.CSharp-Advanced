using System;

class DecimalToHexadecimal
{
    static string DecimalToHexadecimalConvert(long decimalNumber)
    {
        string hexadecimal = string.Empty;

        while (decimalNumber > 0)
        {
            long remainder = decimalNumber % 16;
            if (remainder >= 0 && remainder <= 9)
            {
                hexadecimal = (char)(remainder + 48) + hexadecimal;
            }
            else if (remainder >= 10 && remainder <= 15)
            {
                hexadecimal = (char)(remainder - 10 + 'A') + hexadecimal;
            }

            decimalNumber /= 16;
        }

        return hexadecimal;
    }

    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToHexadecimalConvert(decimalNumber));
    }
}