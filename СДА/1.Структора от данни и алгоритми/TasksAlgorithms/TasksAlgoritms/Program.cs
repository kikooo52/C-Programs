namespace TasksAlgorithms
{
    class Program
    {
        static void Main()
        {
            int[] arr = {142,3432,4234,4,32,2332};
            long count = Task1.Compute(arr);

            int[,] matrix =
                {
                    {5222, 34, 34, 5, 23, 1},
                    {234, 543, 5345, 32, 2, 1}
                };
            Task2 calculate = new Task2();
            long counter = calculate.CalculateCount(matrix);      
  
            Task3 calc = new Task3();
            long newCalculate = calc.CalcSum(matrix, 0);
        }
    }
}
