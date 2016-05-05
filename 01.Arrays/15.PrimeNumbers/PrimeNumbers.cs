using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] numbers = new bool[n + 1];

        for (int i = 2; i <= Math.Sqrt(numbers.Length); i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j += i)
                {
                    numbers[j] = true;
                }
            }
        }

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] == false)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}