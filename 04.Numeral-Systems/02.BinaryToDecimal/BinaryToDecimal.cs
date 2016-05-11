using System;

class BinaryToDecimal
{
    static long BinaryToDecimalConvert(string binaryNumber)
    {
        long result = 0;
        int power = binaryNumber.Length - 1;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int currentNumber = binaryNumber[i] - 48;
            result += currentNumber * (long)Math.Pow(2, power);
            power--;
        }
        
        return result;
    }

    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToDecimalConvert(binaryNumber));
    }
}