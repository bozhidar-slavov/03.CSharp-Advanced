using System;

class RandomNumbers
{
    static void Main()
    {
        Random generator = new Random();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} -> {1}", i, generator.Next(100, 200));
        }
    }
}