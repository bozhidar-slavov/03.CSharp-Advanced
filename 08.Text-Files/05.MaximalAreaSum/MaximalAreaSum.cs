using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\input.txt");
        var writer = new StreamWriter(@"..\..\output.txt");

        using (reader)
        {
            int matrixSize = Convert.ToInt32(reader.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] currentRowNumbers = reader.ReadLine().Split(' ');
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = Convert.ToInt32(currentRowNumbers[j]);
                }
            }

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            using (writer)
            {
                writer.WriteLine(bestSum);
            }
        }
    }
}