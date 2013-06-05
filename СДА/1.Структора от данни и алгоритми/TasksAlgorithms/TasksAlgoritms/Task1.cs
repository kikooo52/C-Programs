namespace TasksAlgorithms
{
    class Task1
    {
       /*
        * for loops n times, as on each loop and while with -1 time
        * => O(n * n)
        */
              
        public static long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;

                while (start < end)
                {
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                        end--;
                }
            }
            return count;
        }
    }
}