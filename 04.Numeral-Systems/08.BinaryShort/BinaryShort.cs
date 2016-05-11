using System;

class BinaryShort
{
    static string GetShortBinaryString(short number)
    {
        char[] binary = new char[16];

        for (int i = 0, position = 15; i < 16; i++, position--)
        {
            if ((number & (1 << i)) != 0)
            {
                binary[position] = '1';
            }
            else
            {
                binary[position] = '0';
            }
        }

        return new string(binary);
    }

    static void Main()
    {
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine(GetShortBinaryString(number));
    }
}