using System;

class NineGagNumbers
{
    static ulong PowerOfNine(int power)
    {
        ulong result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }

        return result;
    }

    static string ConvertToNineGag(string input)
    {
        string result = "NO";
        switch (input)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        string partialInput = string.Empty;
        string nineGagNumber = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];
            ConvertToNineGag(partialInput);
            if (partialInput != "NO")
            {
                string currentDigit = ConvertToNineGag(partialInput);
                if (currentDigit != "NO")
                {
                    nineGagNumber += currentDigit;
                    partialInput = string.Empty;
                }
            }
        }

        ulong result = 0;
        for (int i = 0; i < nineGagNumber.Length; i++)
        {
            ulong currentDigit = ulong.Parse(nineGagNumber[i].ToString());
            result += currentDigit * PowerOfNine(nineGagNumber.Length - i - 1);
        }

        Console.WriteLine(result);
    }
}