/*Това е което можах да направя. Търси само по ред и колона най-дългата поредица от еднакви стрингове*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatrixOfStringsOfSizeNxM
{
    class MatrixOfStringsOfSizeNxM
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            int line = 1;
            int sameline = 0;
            int maxrow = 0;
            int maxcol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();               
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            for (int row = 0; row <= matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        line++;
                        if (line > sameline)
                        {
                            sameline = line;
                            maxrow = row;
                            maxcol = col;
                        }
                    }
                }
                line = 1;
            }
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {

                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        line++;
                        if (line > sameline)
                        {
                            sameline = line;
                            maxrow = row;
                            maxcol = col;
                        }
                    }
                }
                line = 1;
            }

            while (sameline > 0)
            {
                Console.Write(matrix[maxrow, maxcol] + ",");
                sameline--;
            }
            Console.WriteLine();

        }

    }
}