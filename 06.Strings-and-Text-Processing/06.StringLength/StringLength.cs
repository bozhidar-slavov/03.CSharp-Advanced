using System;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Replace("\\", string.Empty);

        if (input.Length <= 20)
        {
            input += new string('*', 20 - input.Length);
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine("Too long string");
        }
    }
}