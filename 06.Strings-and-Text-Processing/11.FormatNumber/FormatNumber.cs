using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal -> {0:D}", number);
        Console.WriteLine("Hexadecimal -> {0:X}", number);
        Console.WriteLine("Percentage -> {0:P}", number);
        Console.WriteLine("Scientific notation -> {0:E}", number);
    }
}