using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasksAlgorithms
{
    class Task2
    {
        /*
         * First for loops n times, have a condition(checking whether the number is divisible) and if executed enters the inner for loop
         * => O(n * m)
         */
         
             
        public long CalculateCount(int[,] matrix)
        {
            long count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
