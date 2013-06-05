namespace TasksAlgorithms
{
   public class Task3
    {

        /*
         * O(n * m)
         * for loops n times and every time call recursive with row + 1
         */
        public long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[row, col];

                if (row + 1 < matrix.GetLength(1))
                {
                    sum += CalcSum(matrix, row + 1);
                }
            }
            return sum;
        }
    }
}