using System;

class MultiverseCommunication
{
    static int ConvertZergDigitToInt(string currentDigit)
    {
        switch (currentDigit)
        {
            case "CHU": return 0; break;
            case "TEL": return 1; break;
            case "OFT": return 2; break;
            case "IVA": return 3; break;
            case "EMY": return 4; break;
            case "VNB": return 5; break;
            case "POQ": return 6; break;
            case "ERI": return 7; break;
            case "CAD": return 8; break;
            case "K-A": return 9; break;
            case "IIA": return 10; break;
            case "YLO": return 11; break;
            case "PLA": return 12; break;
            default: throw new ArgumentException();
        }
    }

    static long PowerOfThirteen(int power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 13;
        }

        return result;
    }

    static void Main()
    {
        string message = Console.ReadLine();
        long result = 0;
        int position = message.Length / 3 - 1;

        for (int i = 0; i < message.Length; i+=3)
        {
            string currentDigit = message.Substring(i, 3);
            result += ConvertZergDigitToInt(currentDigit) * PowerOfThirteen(position);
            position--;
        }

        Console.WriteLine(result);
    }
}