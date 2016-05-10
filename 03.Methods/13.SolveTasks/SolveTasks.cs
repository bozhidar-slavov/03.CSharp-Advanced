using System;
using System.Linq;

class SolveTasks
{
    static string ReversingNumber(string number)
    {
        char[] charArray = number.ToCharArray();
        string reversed = string.Empty;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversed += charArray[i];
        }

        return reversed;
    }

    static decimal CalculateAverage(int[] sequence)
    {
        int sum = 0;
        int counter = 0;
        foreach (var number in sequence)
        {
            sum += number;
            counter++;
        }

        decimal average = (decimal)sum / counter;
        return average;
    }

    static double LinearEquation(int a, int b)
    {
        double x = (double)-b / a;
        return x;
    }

    static void Main()
    {
        Console.WriteLine("Please enter which task you want to solve!");
        Console.WriteLine("Enter 1 - For reversing digits of number");
        Console.WriteLine("Enter 2 - For calculating average value of sequence");
        Console.WriteLine("Enter 3 - For solving a linear equation");
        int choosenTask = int.Parse(Console.ReadLine());

        switch (choosenTask)
        {
            case 1:
                Console.Write("Enter number to reverse: ");
                string number = Console.ReadLine();
                while (number[0] == '-')
                {
                    Console.WriteLine("Please enter positive number!");
                    number = Console.ReadLine();
                }

                Console.WriteLine("Number {0} in reversed format is: {1}", number, ReversingNumber(number));
                break;

            case 2:
                Console.Write("Enter sequence of numbers: ");
                int[] sequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                while (sequence.Length == 0)
                {
                    Console.WriteLine("The sequence should not be empty!");
                    sequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                }

                Console.WriteLine("Average sum: {0:F2}", CalculateAverage(sequence));
                break;

            case 3:
                Console.WriteLine("a * x + b = 0");
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("A should be not equal to zero!");
                    a = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("x = {0:F2}", LinearEquation(a, b));
                break;
        }
    }
}