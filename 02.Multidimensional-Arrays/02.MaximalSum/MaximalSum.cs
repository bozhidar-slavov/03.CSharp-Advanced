using System;
using System.Linq;

class MaximalSum
{
    static void Print(int[,] matrix, int startingRow, int startingCol)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                bool currentRowElementIsInTheSquare = row == startingRow || row == startingRow + 1 || row == startingRow + 2;
                bool currentColElementIsInTheSquare = col == startingCol || col == startingCol + 1 || col == startingCol + 2;
                if (currentColElementIsInTheSquare && currentRowElementIsInTheSquare)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write("{0,3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(currentLine[j]);
            }
        }

        int bestSum = int.MinValue;
        int startingRow = 0;
        int startingCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += matrix[row, col + i] + matrix[row + 1, col + i] + matrix[row + 2, col + i];
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    startingRow = row;
                    startingCol = col;
                }
            }
        }

        // Print(matrix, startingRow, startingCol);
        Console.WriteLine(bestSum);
    }
}