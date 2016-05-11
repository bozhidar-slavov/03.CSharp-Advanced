using System;

class DecimalToBinary
{
    static string DecimalToBinaryConvert(long decimalNumber)
    {
        long remainder = 0;
        string binary = string.Empty;

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            binary = remainder + binary;
        }
        
        return binary;
    }

    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToBinaryConvert(decimalNumber));
    }
}