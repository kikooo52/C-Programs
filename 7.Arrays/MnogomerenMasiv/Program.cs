using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerenMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {1,2,4,5,6},
                {6,5,4,3,2},
            };
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
