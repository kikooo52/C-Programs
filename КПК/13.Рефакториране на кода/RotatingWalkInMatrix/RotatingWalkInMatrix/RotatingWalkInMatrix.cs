using System;

public class RotatingWalkInMatrix
{
    private const int DirectionNumber = 8;

    public static void ChangeDirection(ref int stepX, ref int stepY)
    {
        int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        int curentDirection = 0;

        for (int count = 0; count < DirectionNumber; count++)
        {
            if (directionX[count] == stepX && directionY[count] == stepY)
            {
                curentDirection = count;
                break;
            }
        }
        if (curentDirection == 7)
        {
            stepX = directionX[0];
            stepY = directionY[0];

            return;
        }

        stepX = directionX[curentDirection + 1];
        stepY = directionY[curentDirection + 1];
    }

    public static bool CheckDirection(int[,] arr, int row, int col)
    {
        int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        for (int i = 0; i < DirectionNumber; i++)
        {
            if (row + directionX[i] >= arr.GetLength(0) || row + directionX[i] < 0)
            {
                directionX[i] = 0;
            }


            if (col + directionY[i] >= arr.GetLength(0) || col + directionY[i] < 0)
            {
                directionY[i] = 0;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            if (arr[row + directionX[i], col + directionY[i]] == 0) return true;
        }

        return false;
    }

    public static void FindEmptyCell(int[,] matrix, out int currentRow, out int currentCol)
    {
        currentRow = 0;
        currentCol = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[i, j] == 0)
                {
                    currentRow = i;
                    currentCol = j;

                    return;
                }
            }
        }
    }

    public static int[,] GenerateRotationgMatrix(int sizeOnMatrix)
    {
        int[,] matrix = new int[sizeOnMatrix, sizeOnMatrix];
        int number = 1;
        int col = 0;
        int row = 0;
        int directionRow = 1;
        int directionCol = 1;

        while (true)
        {
            matrix[col, row] = number;

            if (!CheckDirection(matrix, col, row))
            {
                break;
            }
            if (col + directionRow >= sizeOnMatrix || col + directionRow < 0 || row + directionCol >=
                sizeOnMatrix || row + directionCol < 0 || matrix[col + directionRow, row + directionCol] != 0)
            {
                while ((col + directionRow >= sizeOnMatrix || col + directionRow < 0 || row + directionCol >=
                    sizeOnMatrix || row + directionCol < 0 || matrix[col + directionRow, row + directionCol] != 0))
                {
                    ChangeDirection(ref directionRow, ref directionCol);
                }
            }
            col += directionRow;
            row += directionCol;
            number++;
        }

        FindEmptyCell(matrix, out col, out row);
        number++;
        if (col != 0 && row != 0)
        {
            directionRow = 1;
            directionCol = 1;


            while (true)
            {
                matrix[col, row] = number;
                if (!CheckDirection(matrix, col, row))
                {
                    break;
                }
                if (col + directionRow >= sizeOnMatrix || col + directionRow < 0 || row + directionCol >= sizeOnMatrix || row + directionCol < 0 ||
                    matrix[col + directionRow, row + directionCol] != 0)


                    while ((col + directionRow >= sizeOnMatrix || col + directionRow < 0 || row + directionCol >= sizeOnMatrix || row + directionCol < 0 ||
                        matrix[col + directionRow, row + directionCol] != 0))
                        ChangeDirection(ref directionRow, ref directionCol);
                col += directionRow;
                row += directionCol;
                number++;
            }
        }
        WriteMatrixOnConsole(matrix);
        return matrix;
    }

    private static void WriteMatrixOnConsole(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }


}

