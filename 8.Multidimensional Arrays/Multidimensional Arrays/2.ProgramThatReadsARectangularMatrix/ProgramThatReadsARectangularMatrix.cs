using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ProgramThatReadsARectangularMatrix
{
    class ProgramThatReadsARectangularMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1);col++)
                {
                    matrix[row,col] = int.Parse(Console.ReadLine());
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
            Console.WriteLine();
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum>bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine("  {0,4} {1,4} {2,4}",
                matrix[bestRow, bestCol],
                matrix[bestRow, bestCol + 1],
                matrix[bestRow, bestCol + 2]);
            Console.WriteLine("  {0,4} {1,4} {2,4}",
                matrix[bestRow+1, bestCol],
                matrix[bestRow+1, bestCol + 1],
                matrix[bestRow+1, bestCol + 2]);
            Console.WriteLine("  {0,4} {1,4} {2,4}",
                matrix[bestRow+2, bestCol],
                matrix[bestRow+2, bestCol + 1],
                matrix[bestRow+2, bestCol + 2]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);
          
          
          
        }
    }
}
