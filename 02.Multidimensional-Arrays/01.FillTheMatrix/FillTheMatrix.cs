using System;

class FillTheMatrix
{
    static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);
                }
            }

            Console.WriteLine();
        }
    }

    static void FirstMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int currentValue = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = currentValue;
                currentValue++;
            }
        }

        Print(matrix);
    }

    static void SecondMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int currentValue = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = currentValue;
                    currentValue++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentValue;
                    currentValue++;
                }
            }
        }

        Print(matrix);
    }

    static void ThirdMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int startRow = n - 1;
        int startCol = 0;
        int jumper = 0;

        for (int currentValue = 1; currentValue <= n * n; currentValue++)
        {
            int currentRow = startRow + jumper;
            int currentCol = startCol + jumper;
            matrix[currentRow, currentCol] = currentValue;
            jumper++;

            if (startRow > 0 && currentRow == n - 1)
            {
                startRow--;
                jumper = 0;
            }
            else if (currentCol == n - 1)
            {
                startCol++;
                jumper = 0;
            }
        }

        Print(matrix);
    }

    static void FourthMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        bool[,] visitedCells = new bool[n, n];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";

        for (int currentValue = 1; currentValue <= n * n; currentValue++)
        {
            matrix[currentRow, currentCol] = currentValue;
            visitedCells[currentRow, currentCol] = true;

            switch (direction)
            {
                case "down":
                    if (currentRow == n - 1 || visitedCells[currentRow + 1, currentCol] == true)
                    {
                        currentCol++;
                        direction = "right";
                    }
                    else
                    {
                        currentRow++;
                    };
                    break;

                case "right":
                    if (currentCol == n - 1 || visitedCells[currentRow, currentCol + 1] == true)
                    {
                        currentRow--;
                        direction = "up";
                    }
                    else
                    {
                        currentCol++;
                    };
                    break;

                case "up":
                    if (currentRow == 0 || visitedCells[currentRow - 1, currentCol] == true)
                    {
                        currentCol--;
                        direction = "left";
                    }
                    else
                    {
                        currentRow--;
                    };
                    break;

                case "left":
                    if (visitedCells[currentRow, currentCol - 1] == true)
                    {
                        currentRow++;
                        direction = "down";
                    }
                    else
                    {
                        currentCol--;
                    };
                    break;
            }
        }

        Print(matrix);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char matrix = char.Parse(Console.ReadLine());

        switch (matrix)
        {
            case 'a': FirstMatrix(n); break;
            case 'b': SecondMatrix(n); break;
            case 'c': ThirdMatrix(n); break;
            case 'd': FourthMatrix(n); break;
        }
    }
}