using System;
using System.Linq;

class LoverOf3
{
    static int[,] FillMatrix(int[,] matrix, int currentRowValue, int tempRowValue)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = tempRowValue;
                tempRowValue += 3;
            }

            tempRowValue = currentRowValue - 3;
            currentRowValue -= 3;
        }

        return matrix;
    }

    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = input[0];
        int m = input[1];

        int currentRowValue = (input[0] - 1) * 3;
        int tempRowValue = currentRowValue;

        int[,] matrix = new int[n, m];
        FillMatrix(matrix, currentRowValue, tempRowValue);

        int numberOfMoves = int.Parse(Console.ReadLine());
        long sum = 0;
        int currentRow = n - 1;
        int currentCol = 0;
        for (int i = 0; i < numberOfMoves; i++)
        {
            string[] currentCommand = Console.ReadLine().Split(' ');
            string direction = currentCommand[0];
            int moves = int.Parse(currentCommand[1]);

            if (direction == "UR" || direction == "RU")
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (currentRow == 0 || currentCol == m - 1)
                    {
                        break;
                    }

                    currentRow--;
                    currentCol++;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                }
            }
            else if (direction == "LU" || direction == "UL")
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (currentRow == 0 || currentCol == 0)
                    {
                        break;
                    }

                    currentCol--;
                    currentRow--;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                }
            }
            else if (direction == "DL" || direction == "LD")
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (currentRow == n - 1 || currentCol == 0)
                    {
                        break;
                    }

                    currentRow++;
                    currentCol--;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                }
            }
            else if (direction == "RD" || direction == "DR")
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (currentRow == n - 1 || currentCol == m - 1)
                    {
                        break;
                    }

                    currentRow++;
                    currentCol++;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                }
            }
        }

        Console.WriteLine(sum);
    }
}