using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main(string[] args)
    {
          int[] arr =new int[100];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
        }

      
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
                Console.Write(arr[i]+",");
           }
            Console.WriteLine();

        }


    }    

    

