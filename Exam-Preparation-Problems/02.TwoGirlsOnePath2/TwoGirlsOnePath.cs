using System;
using System.Numerics;
using System.Linq;

class TwoGirlsOnePath
{
    static void Main()
    {
        var field = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

        // initialize variables
        int positionOfMolly = 0;
        int positionOfDolly = field.Length - 1;

        BigInteger basketOfMolly = 0;
        BigInteger basketOfDolly = 0;

        // start playing
        while (field[positionOfMolly] != 0 && field[positionOfDolly] != 0)
        {
            BigInteger nextMollyStep = field[positionOfMolly];
            BigInteger nextDollyStep = field[positionOfDolly];

            // collect flowers
            if (positionOfMolly != positionOfDolly)
            {
                basketOfMolly += field[positionOfMolly];
                basketOfDolly += field[positionOfDolly];

                field[positionOfMolly] = 0;
                field[positionOfDolly] = 0;
            }
            else
            {
                basketOfMolly += field[positionOfMolly] / 2;
                basketOfDolly += field[positionOfDolly] / 2;

                field[positionOfMolly] = 1;
            }

            // jump to next cell
            var nextMollyPosition = positionOfMolly + nextMollyStep;
            if (nextMollyPosition > field.Length - 1)
            {
                nextMollyPosition = nextMollyPosition % field.Length;
            }

            positionOfMolly = (int)nextMollyPosition;


            var nextDollyPosition = positionOfDolly - nextDollyStep;
            if (nextDollyPosition < 0)
            {
                nextDollyPosition = field.Length + (nextDollyPosition % field.Length);
                if (nextDollyPosition == field.Length)
                {
                    nextDollyPosition = 0;
                }
            }

            positionOfDolly = (int)nextDollyPosition;
        }

        basketOfMolly += field[positionOfMolly];
        basketOfDolly += field[positionOfDolly];

        // print result
        if (field[positionOfMolly] == 0 && field[positionOfDolly] == 0)
        {
            Console.WriteLine("Draw");
        }
        else if (field[positionOfMolly] == 0)
        {
            Console.WriteLine("Dolly");
        }
        else
        {
            Console.WriteLine("Molly");
        }

        Console.WriteLine(basketOfMolly + " " + basketOfDolly);
    }
}