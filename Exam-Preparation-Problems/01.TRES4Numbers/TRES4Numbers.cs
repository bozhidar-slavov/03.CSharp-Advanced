using System;

class TRES4Numbers
{
    static void Main()
    {
        ulong decimalNumber = ulong.Parse(Console.ReadLine());
        
        string result = string.Empty;
        ulong remainder = 0;

        if (decimalNumber == 0)
        {
            result = "LON+";
        }

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 9;
            switch (remainder)
            {
                case 0: result = "LON+" + result; break;
                case 1: result = "VK-" + result; break;
                case 2: result = "*ACAD" + result; break;
                case 3: result = "^MIM" + result; break;
                case 4: result = "ERIK|" + result; break;
                case 5: result = "SEY&" + result; break;
                case 6: result = "EMY>>" + result; break;
                case 7: result = "/TEL" + result; break;
                case 8: result = "<<DON" + result; break;
            }

            decimalNumber /= 9;
        }

        Console.WriteLine(result);
    }
}