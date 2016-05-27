using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            double n = double.Parse(Console.ReadLine());

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }

            Console.WriteLine("{0:F3}", Math.Sqrt(n));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}