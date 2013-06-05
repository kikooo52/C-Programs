using System;

class ReadsTwoIntegerNumbersNAndK
{
    static void Main()
    {
        int sum = 0;
        Console.Write("Enter num K:");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter num N:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        if (k > array.Length)
        {
            return;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element of N:");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(array);
        for (int j = array.Length - 1; j >= array.Length - k; j--)
        {
            sum += array[j];
        }
        Console.WriteLine(sum);
    }
}
