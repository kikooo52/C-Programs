using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ProgramThatFillsPrintsAMatrix
{
    class ProgramThatFillsPrintsAMatrix
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.Write("Enter size on matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = counter;       
                    counter++;            
                }
            }
            Console.WriteLine("\"a)\"");
            Print(size, matrix);
            counter = 1;
            Array.Clear(matrix, 0, matrix.Length);

            for (int col = 0; col < size; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = size - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;  
                    }
                }
                
            }
            Console.WriteLine("\"b)\"");
            Print(size, matrix);

            counter = 1;
            Array.Clear(matrix, 0, matrix.Length);

            for (int diagonal = 0; diagonal < (size*2); diagonal++)
            {
                int row = size - 1 - diagonal;
                int col = 0;
                if (row < 0)
                {
                    row = 0;
                }
                if (diagonal >= size)
                {
                    col = diagonal - size + 1;
                }
                while (row < size && col < size)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row++;
                    col++;
                }
            }
            Console.WriteLine("\"c)\"");
            Print(size, matrix);
            
        }
                private static void Print(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
