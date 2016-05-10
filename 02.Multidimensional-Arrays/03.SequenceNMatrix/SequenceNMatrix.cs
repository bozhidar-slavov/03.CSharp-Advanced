using System;
using System.Linq;

class SequenceNMatrix
{
    static int LongestSequence(string[,] matrix)
    {
        int currentCount = 1;
        int bestCount = 0;
        string itemMostCounted = string.Empty;

        // check by rows
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    itemMostCounted = matrix[row, col];
                }
            }

            currentCount = 1;
        }

        // check by columns
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    itemMostCounted = matrix[row, col];
                }
            }

            currentCount = 1;
        }

        //check by diagonal left to right
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column < matrix.GetLength(1) - 1; row++, column++)
            {
                if ((matrix[row, column] == matrix[row + 1, column + 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    itemMostCounted = matrix[row, column];
                }
            }

            currentCount = 1;
        }


        //check by diagonal right to left
        for (int col = matrix.GetLength(1) - 1; col > 0; col--)
        {
            for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column > 0; row++, column--)
            {
                if ((matrix[row, column] == matrix[row + 1, column - 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    itemMostCounted = matrix[row, column];
                }
            }
        }

        // return string.Join(", ", Enumerable.Repeat(itemMostCounted, bestCount).ToArray());
        return bestCount;
    }

    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = currentLine[j];
            }
        }

        Console.WriteLine(LongestSequence(matrix));
    }
}