using System;
using System.Numerics;

class StrangeLandNumbers
{
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }

    static void Main()
    {
        string strangeLandNumber = Console.ReadLine();

        string strangeSystem = string.Empty;
        foreach (var letter in strangeLandNumber)
        {
            if (char.IsLower(letter))
            {
                switch (letter)
                {
                    case 'f': strangeSystem += 0; break;
                    case 'b': strangeSystem += 1; break;
                    case 'o': strangeSystem += 2; break;
                    case 'm': strangeSystem += 3; break;
                    case 'l': strangeSystem += 4; break;
                    case 'p': strangeSystem += 5; break;
                    case 'h': strangeSystem += 6; break;
                }
            }
        }

        BigInteger result = 0;
        int power = 0;
        for (int i = strangeSystem.Length - 1; i >= 0; i--)
        {
            int currentNum = strangeSystem[i] - 48;
            result += currentNum * Power(7, power);
            power++;
        }

        Console.WriteLine(result);
    }
}