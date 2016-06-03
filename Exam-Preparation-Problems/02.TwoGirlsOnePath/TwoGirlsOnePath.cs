using System;
using System.Linq;
using System.Numerics;

class TwoGirlsOnePath
{
    static void Main()
    {
        BigInteger[] gameField = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

        BigInteger mollyFlowers = 0;
        BigInteger dollyFlowers = 0;

        int mollyIndex = 0;
        int dollyIndex = gameField.Length - 1;

        while (true)
        {
            BigInteger mollyJumps = gameField[mollyIndex];
            BigInteger dollyJumps = gameField[dollyIndex];
            if (mollyIndex != dollyIndex)
            {
                mollyFlowers += gameField[mollyIndex];
                dollyFlowers += gameField[dollyIndex];
                if (gameField[mollyIndex] == 0 || gameField[dollyIndex] == 0)
                {
                    break;
                }

                gameField[mollyIndex] = 0;
                gameField[dollyIndex] = 0;
            }
            else
            {
                mollyFlowers += gameField[mollyIndex] / 2;
                dollyFlowers += gameField[dollyIndex] / 2;
                if (gameField[mollyIndex] == 0 || gameField[dollyIndex] == 0)
                {
                    break;
                }

                if (gameField[mollyIndex] % 2 == 0)
                {
                    gameField[mollyIndex] = 0;
                }
                else
                {
                    gameField[mollyIndex] = 1;
                }
            }

            mollyIndex = (int)((mollyIndex + mollyJumps) % gameField.Length);
            dollyIndex = (int)((gameField.Length + ((dollyIndex - dollyJumps) % gameField.Length)) % gameField.Length);
        }

        if (gameField[mollyIndex] == 0 && gameField[dollyIndex] == 0)
        {
            Console.WriteLine("Draw");
        }
        else if (gameField[mollyIndex] == 0)
        {
            Console.WriteLine("Dolly");
        }
        else
        {
            Console.WriteLine("Molly");
        }

        Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
    }
}