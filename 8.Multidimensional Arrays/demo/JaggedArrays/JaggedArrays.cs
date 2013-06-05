using System;

class JaggedArrays
{
	static void Main()
	{
        TreeDeArray();


        //int[] numbers = { 0,1,4,113,55,3,1,2,66,557,124,2 };
        //int[] sizes = new int[3];
        //int[] offsets = new int[3];
		
        //// Calculate the sizes for each reminder (0, 1 and 2)
        //foreach (var number in numbers)
        //{
        //    int remainder = number % 3;
        //    sizes[remainder]++;
        //}

        //// Calculate the list of numbers for each reminder (0, 1 and 2)
        //int[][] numbersByRemainder = new int[3][] { 
        //    new int[sizes[0]], new int[sizes[1]], new int[sizes[2]] 
        //};
        //foreach (var number in numbers)
        //{
        //    int remainder = number % 3; 
        //    int index = offsets[remainder];
        //    numbersByRemainder[remainder][index] = number;
        //    offsets[remainder]++;
        //}

        //// Print the result jagged array
        //for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
        //{
        //    foreach (var num in numbersByRemainder[row])
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();
        //}
	}

    private static void TreeDeArray()
    {
        int[, ,] cube = new int[3, 2, 4]
        {
            {
                {1,2,3,4},
                {5,6,7,8},
            },
            {
                 {-1,-2,-3,-4},
                 {-5,-6,-7,-8},
            },
            {
                 {01,02,03,04},
                 {05,06,07,08},
            }
        };
        for (int height = 0; height < cube.GetLength(0); height++)
        {
            for (int row = 0; row < cube.GetLength(1); row++)
            {
                for (int col = 0; col < cube.GetLength(2); col++)
                {
                    Console.Write(cube[height, row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
