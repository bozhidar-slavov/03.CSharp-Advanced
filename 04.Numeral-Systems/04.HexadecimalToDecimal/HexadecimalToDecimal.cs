using System;

class HexadecimalToDecimal
{
    static long HexadecimalToDecimalConvert(string hexadecimalNumber)
    {
        long result = 0;
        int power = hexadecimalNumber.Length - 1;
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            int currentDigit = 0;
            if (hexadecimalNumber[i] >= '0' && hexadecimalNumber[i] <= '9')
            {
                currentDigit = hexadecimalNumber[i] - '0';
            }
            else if (hexadecimalNumber[i] >= 'A' && hexadecimalNumber[i] <= 'F')
            {
                currentDigit = hexadecimalNumber[i] - 'A' + 10;
            }

            result += currentDigit * (long)Math.Pow(16, power);
            power--;
        }

        return result;
    }

    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();

        Console.WriteLine(HexadecimalToDecimalConvert(hexadecimalNumber));
    }
}