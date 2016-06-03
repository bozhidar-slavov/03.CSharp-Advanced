using System;

class Patterns
{
    static int[,] FillMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(currentLine[j]);
            }
        }

        return matrix;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = FillMatrix(n);
        long mainDiagonalSum = 0;
        long currentSum = 0;
        long bestSum = long.MinValue;
        bool foundSum = false;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < n - 4; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1] - 1 && matrix[i, j + 1] == matrix[i, j + 2] - 1 && matrix[i, j + 2] == matrix[i + 1, j + 2] - 1 && matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1 && matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1 && matrix[i + 2, j + 3] == matrix[i + 2, j + 4] - 1)
                {
                    currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2] + matrix[i + 2, j + 3] + matrix[i + 2, j + 4];
                    foundSum = true;
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 0;
                }
            }
        }

        if (foundSum == true)
        {
            Console.WriteLine("YES " + bestSum);
        }
        else
        {
            int row = 0;
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[row, col];
                row++;
                col++;
            }

            Console.WriteLine("NO " + mainDiagonalSum);
        }
    }
}